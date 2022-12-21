using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUsersService
    {
        IResult Add(User users);
        IResult Delete(User users);
        IResult Update(User users);
        IDataResult<List<User>> GetAll();
    }
}
