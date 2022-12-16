using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVeterinerianService
    {
        IResult Add(Veterinerian veterinerian);
        IResult Delete(Veterinerian veterinerian);
        IResult Update(Veterinerian veterinerian);
        IDataResult<List<Veterinerian>> GetAll();
    }
}
