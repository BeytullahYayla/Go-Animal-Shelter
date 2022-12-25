using Business.Abstract;
using Core.Extensions;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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

    

        public IResult Update(User users)
        {
            _usersDal.Update(users);
            return new SuccessResult("Users Updated Succesfuly");
        }
        public List<Claim> GetClaims(User user, List<OperationClaim> operationClaims)
        {

            using (var context = new Context())
            {
                //var result = from operationClaim in context.OperationClaims
                //             join userOperationClaim in context.UserOperationClaims
                //                 on operationClaim.Id equals userOperationClaim.OperationClaimID
                //             where userOperationClaim.UserID == user.UserID
                //             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                //return result.ToList();


                var claims = new List<Claim>();
                claims.AddNameIdentifier(user.UserID.ToString());
                claims.AddEmail(user.Email!);
                claims.AddName($"{user.FirstName} {user.LastName}");
                claims.AddRoles(operationClaims);
                return claims;

            }
        }
    }
}
