using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AnimalCategoryController : ControllerBase
	{
		IAnimalCategoryService _animalCategoryService;
		public AnimalCategoryController(IAnimalCategoryService animalCategoryService)
		{
			_animalCategoryService = animalCategoryService;
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			var result=_animalCategoryService.GetAll();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest();
		}

		[HttpPost]
		public IActionResult Add(AnimalCategory animalCategory)
		{
			var result = _animalCategoryService.Add(animalCategory);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest();
		}

		[HttpPost]
		public IActionResult Delete(AnimalCategory animalCategory)
		{
			var result = _animalCategoryService.Delete(animalCategory);
				if (result.Success) { 
				return Ok(result);
			}
			return BadRequest();
		}

		[HttpPost]
		public IActionResult Update(AnimalCategory animalCategory) { 
			var result = _animalCategoryService.Update(animalCategory);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest();
		}
	}
}
