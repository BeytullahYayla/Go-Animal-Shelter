﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Migrations;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PetOwnerManager : IPetOwnerService
    {
        private IPetOwnerDal _petOwnerDal;

        public PetOwnerManager(IPetOwnerDal petOwnerDal)
        {
            _petOwnerDal = petOwnerDal;
        }

        public IResult Add(Entities.Concrete.PetOwner petOwner)
        {
            _petOwnerDal.Add(petOwner);
            return new SuccessResult("Pet Owner Added Successfully");
        }

        public IResult Delete(Entities.Concrete.PetOwner petOwner)
        {
            _petOwnerDal.Delete(petOwner);
            return new SuccessResult("Pet Owner Deleted Successfully");
        }

        public IDataResult<List<Entities.Concrete.PetOwner>> GetAll()
        {
            return new SuccessDataResult<List<Entities.Concrete.PetOwner>>(_petOwnerDal.GetAll(), "Pet Owner Listed Succesfuly");
        }

        public IDataResult<Entities.Concrete.PetOwner> GetById(int id)
        {
            return new SuccessDataResult<Entities.Concrete.PetOwner>(_petOwnerDal.Get(p => p.PetOwnerId == id));
        }

        public IResult Update(Entities.Concrete.PetOwner petOwner)
        {
            _petOwnerDal.Update(petOwner);
            return new SuccessResult("Pet Owner Updated Successfully");
        }
    }
}