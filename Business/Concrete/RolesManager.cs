using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RolesManager : IRolesService
    {
        IRolesDal _rolesDal;
        public RolesManager(IRolesDal rolesDal) { 
            _rolesDal= rolesDal;
        }
        public IResult Add(Roles roles)
        {
            _rolesDal.Add(roles);
            return new SuccessResult("Roles Added Successfully");
        }

        public IResult Delete(Roles roles)
        {
            _rolesDal.Delete(roles);
            return new SuccessResult("Roles Deleted Successfully");
        }

        public IDataResult<List<Roles>> GetAll()
        {
            
            return new SuccessDataResult<List<Roles>>(_rolesDal.GetAll(),"Roles Listed Successfully");
        }

        public IResult Update(Roles roles)
        {
            _rolesDal.Update(roles);
            return new SuccessResult("Roles Update Successfully");
        }
    }
}
