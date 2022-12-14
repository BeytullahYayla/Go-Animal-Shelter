using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class ServiceManager : IServiceService
	{
		EfServiceDal _serviceDal;
		public ServiceManager(EfServiceDal serviceDal)
		{
			_serviceDal = serviceDal;
		}

		public IResult Add(Service service)
		{
			_serviceDal.Add(service);
			return new SuccessResult("Service Added Successfully");
			
		}

		public IResult Delete(Service service)
		{
			_serviceDal.Delete(service);
			return new SuccessResult("Service Deleted Successfully");
		}

		public IDataResult<List<Service>> GetAll()
		{
			return new SuccessDataResult<List<Service>>(_serviceDal.GetAll(),"Services Listed Successfully");
		}

		public IDataResult<Service> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IResult Update(Service service)
		{
			_serviceDal.Update(service);
			return new SuccessResult("Entity Updated Successfully");
		}
	}
}
