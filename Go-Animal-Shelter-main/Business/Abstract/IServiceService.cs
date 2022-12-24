using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IServiceService
	{
		IDataResult<List<Service>> GetAll();
		IDataResult<Service> GetById(int id);

		IResult Add(Service service);
		IResult Update(Service service);
		IResult Delete(Service service);
	}

}
