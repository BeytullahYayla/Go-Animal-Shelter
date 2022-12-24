using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
        public PetManager(IPetDal petDal)
        {
            _petDal=petDal;
        }

        public IResult Add(Pet pet)
        {
            _petDal.Add(pet);
            return new SuccessResult("Pet Added Successfully");
        }

        public IResult Delete(Pet pet)
        {
            _petDal.Delete(pet);
            return new SuccessResult("Pet Deleted Successfully");
        }

        public IDataResult<List<Pet>> GetAll()
        {
            return new SuccessDataResult<List<Pet>>(_petDal.GetAll(), "Listed Successfully");
        }

        public IDataResult<Pet> GetById(int id)
        {
            return new SuccessDataResult<Pet>(_petDal.Get(p => p.Id == id), "Pet listed by id");
        }

        public IDataResult<Pet> GetByName(string name)
        {
            return new SuccessDataResult<Pet>(_petDal.Get(p=>p.Name==name), "Pet listed by petname");    
        }

        public IDataResult<List<PetDto>> GetPetDetails()
        {
            return new SuccessDataResult<List<PetDto>>(_petDal.GetPetDetails(), "Pet Details Listed");
        }

        public IResult Remove(Pet pet)
        {
            _petDal.Delete(pet);
            return new SuccessResult("Pet Deleted Successfully");
        }

        public IResult Update(Pet pet)
        {
            _petDal.Update(pet);
            return new SuccessResult();
        }
    }
}
