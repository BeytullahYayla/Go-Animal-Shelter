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
	public class AnimalCategoryManager : IAnimalCategoryService
	{
		IAnimalCategoryDal _animalCategoryDal;
		public AnimalCategoryManager(IAnimalCategoryDal animalCategoryDal)
		{
			_animalCategoryDal = animalCategoryDal;
		}

		public IResult Add(AnimalCategory animalCategory)
		{
			_animalCategoryDal.Add(animalCategory);
			return new SuccessResult();
		}

		public IDataResult<List<AnimalCategory>> GetAll()
		{
			return new SuccessDataResult<List<AnimalCategory>>(_animalCategoryDal.GetAll(),"Isleminiz basarili");
		}

		public IResult Remove(AnimalCategory animalCategory)
		{
			_animalCategoryDal.Delete(animalCategory);
			return new SuccessResult();	
		}

		public IResult Update(AnimalCategory Category)
		{
			_animalCategoryDal.Update(Category);
			return new SuccessResult();
		}
	}
}
