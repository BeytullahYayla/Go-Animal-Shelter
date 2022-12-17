using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPetService
    {
        IDataResult<List<Pet>> GetAll();

        IDataResult<Pet> GetById(int id);

        IDataResult<Pet> GetByName(string name);
        

        IResult Add(Pet pet);

        IResult Remove(Pet pet);

        IResult Update(Pet pet);

        IResult Delete(Pet pet);


    }
}
