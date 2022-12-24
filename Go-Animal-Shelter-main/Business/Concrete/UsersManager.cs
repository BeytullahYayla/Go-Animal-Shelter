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

        public IResult Add(User users)
        {
            _usersDal.Add(users);
            return new SuccessResult("Users Added Succesfuly");
        }

        public IResult Delete(User users)
        {
            _usersDal.Delete(users);
            return new SuccessResult("Users Deleted Succesfuly");
        }

        public IDataResult<List<User>> GetAll()
        {
            
            return new SuccessDataResult<List<User>>(_usersDal.GetAll(),"Users Listed Succesfuly");
        }

        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>(_usersDal.Get(p => p.Email == email),"User listed by email successfully");
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_usersDal.GetClaims(user), "Claims Listed Successfully");
        }

        public IResult Update(User users)
        {
            _usersDal.Update(users);
            return new SuccessResult("Users Updated Succesfuly");
        }
    }
}
