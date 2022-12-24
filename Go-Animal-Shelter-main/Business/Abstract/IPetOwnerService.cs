using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPetOwnerService
    {
        IDataResult<List<PetOwner>> GetAll();

        IResult Add(PetOwner petOwner);
        IResult Delete(PetOwner petOwner);
        IResult Update(PetOwner petOwner);

        IDataResult<PetOwner> GetById(int id);
    }
}
