using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPetDal:EfEntityRepositoryBase<Pet,Context>,IPetDal
    {
        public List<PetDto> GetPetDetails(Expression<Func<PetDto, bool>> filter = null)
        {
            using (Context context=new Context())
            {
                var result = from pe in context.Pets
                             join ac in context.AnimalCategories
                             on pe.AnimalCategoryId equals ac.Id
                             join sp in context.Species
                             on pe.speciesId equals sp.Id
                             join po in context.PetsOwners
                             on pe.PetOwnerId equals po.PetOwnerId


                             select new PetDto
                             {
                                 PetId = pe.Id,
                                 AnimalCategoryId = ac.Id,
                                 SpeciesId = sp.Id,
                                 Age = pe.Age,
                                 AnimalCategoryName = ac.Name,
                                 Description = pe.Description,
                                 ImagePath = pe.ImagePath,
                                 PetName = pe.Name,
                                 PetOwnerName = po.FirstName + " "+po.LastName,
                                 SpeciesName = sp.Name

                             };
                return filter == null
             ? result.ToList()
             : result.Where(filter).ToList();


            }
        }
    }
}
