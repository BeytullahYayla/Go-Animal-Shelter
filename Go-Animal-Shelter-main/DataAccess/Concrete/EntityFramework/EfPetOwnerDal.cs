using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPetOwnerDal : EfEntityRepositoryBase<PetOwner, Context>, IPetOwnerDal
    {
        public List<PetOwnerDto> GetDetails()
        {
            using (Context context=new Context())
            {
                var result = from po in context.PetsOwners
                             join pe in context.Pets
                             on po.PetId equals pe.Id
                             select new PetOwnerDto
                             {
                                 Id = po.PetOwnerId,
                                 PetName = pe.Name,
                                 PetOwnerEmail = po.Email,
                                 PetOwnerName = po.FirstName,
                                 PetOwnerPhone = po.Tel,
                                 PetOwnerSurname = po.LastName
                             };

                return result.ToList();
            }
            
        }
    }
}
