using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PetManager : IPetService
    {
        IPetDal _petDal;
        public PetManager(IPetDal petDal) {
            _petDal = petDal;
        }
        public IResult Add(Pet pet)
        {
            _petDal.Add(pet);
            return new SuccessResult("Pet Added Succesfuly");
        }

        public IResult Delete(Pet pet)
        {
            _petDal.Delete(pet);
            return new SuccessResult("Pet Deleted Succesfuly");
        }

        public IDataResult<List<Pet>> GetAll()
        {
            return new SuccessDataResult<List<Pet>>(_petDal.GetAll(),"Pet Listed Succesfuly");
        }

        public IResult Update(Pet pet)
        {
            _petDal.Update(pet);
            return new SuccessResult("Pet Updated Succesfuly");
        }
    }
}
