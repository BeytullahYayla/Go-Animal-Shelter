using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VeterinerianManager:IVeterinerianService
    {
        IVeterinerianDal _veterinerian;
        public VeterinerianManager(IVeterinerianDal veterinerian)
        {
            _veterinerian = veterinerian;
        }

       
        public IResult Add(Veterinerian veterinerian)
        {
            _veterinerian.Add(veterinerian);
            return new SuccessResult("Veterinerian Added Successfully");
        }

        public IResult Delete(Veterinerian veterinerian)
        {
            _veterinerian.Delete(veterinerian);
            return new SuccessResult("Veterinerian Deleted Successfully");
        }

        public IDataResult<List<Veterinerian>> GetAll()
        {
            return new SuccessDataResult<List<Veterinerian>>(_veterinerian.GetAll(), "Veterinerian Listed Successfully");
        }

        public IResult Update(Veterinerian veterinerian)
        {
            _veterinerian.Update(veterinerian);
            return new SuccessResult("Veterinerian Updated Successfully");
        }
    }
}
