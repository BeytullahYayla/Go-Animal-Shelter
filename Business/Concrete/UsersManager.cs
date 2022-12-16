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
    public class UsersManager : IUsersService
    {
        IUsersDal _usersDal;
        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }

        public IResult Add(Users users)
        {
            _usersDal.Add(users);
            return new SuccessResult("Users Added Succesfuly");
        }

        public IResult Delete(Users users)
        {
            _usersDal.Delete(users);
            return new SuccessResult("Users Deleted Succesfuly");
        }

        public IDataResult<List<Users>> GetAll()
        {
            
            return new SuccessDataResult<List<Users>>(_usersDal.GetAll(),"Users Listed Succesfuly");
        }

        public IResult Update(Users users)
        {
            _usersDal.Update(users);
            return new SuccessResult("Users Updated Succesfuly");
        }
    }
}
