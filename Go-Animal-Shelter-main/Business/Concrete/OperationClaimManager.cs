using Business.Abstract;
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
    public class OperationClaimManager : IOperationClaimService
    {
        IOperationClaimDal _operationClaimDal;

        public OperationClaimManager(IOperationClaimDal operationClaimDal)
        {
            _operationClaimDal = operationClaimDal;
        }

        public List<OperationClaim> GetRoles()
        {
            return this._operationClaimDal.GetAll();
        }

        public List<UserOperationClaimDto> GetUserOperationClaims()
        {
            return this._operationClaimDal.GetUserOperationClaims();
        }
    }
}
