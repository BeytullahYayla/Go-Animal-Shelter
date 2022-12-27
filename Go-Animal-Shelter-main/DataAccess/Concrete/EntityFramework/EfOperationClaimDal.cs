using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOperationClaimDal:EfEntityRepositoryBase<OperationClaim,Context>,IOperationClaimDal
    {
        public List<UserOperationClaimDto> GetUserOperationClaims()
        {
            using (Context context=new Context())
            {
                var result = from u in context.UserOperationClaims
                             join o in context.OperationClaims
                             on u.OperationClaimID equals o.Id
                             join user in context.Users
                             on u.UserID equals user.UserID
                             select new UserOperationClaimDto
                             {
                                 Id = u.Id,
                                 UserId = u.UserID,
                                 UserName = user.FirstName + " " + user.LastName,
                                 RoleName = o.Name

                             };
                return result.ToList();



            }
            
        }
    }
}
