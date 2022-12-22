using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Go_Animal_Shelter.Controllers
{
	public class AdminController : Controller
	{
		AnimalCategoryManager animalCategoryManager = new AnimalCategoryManager(new EfAnimalCategoryDal());
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult List()
		{
			var result=animalCategoryManager.GetAll();
			if (result.Success)
			{
                return View(result.Data);
            }
			return View("Index");
			
		}

		public IActionResult AddAnimalCategory()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddAnimalCategory(AnimalCategory animalCategory)
		{
			var result=animalCategoryManager.Add(animalCategory);
			if (result.Success)
			{
				return RedirectToAction("List");
			}
			return View();
			
		}

		public IActionResult Update()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Update(AnimalCategory animalCategory)
		{
			var result=animalCategoryManager.Update(animalCategory);
			if (result.Success)
			{
				return RedirectToAction("List");
			}
			return View();

		}


	}
}
