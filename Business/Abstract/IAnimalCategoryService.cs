using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IAnimalCategoryService
	{
		IResult Add(AnimalCategory animalCategory);
		IResult Remove(AnimalCategory animalCategory);

		IResult Update(AnimalCategory Category);
		IDataResult<List<AnimalCategory>> GetAll();
	}
}
