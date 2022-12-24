using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

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

		[HttpGet("GetAll")]
		public IActionResult GetAll()
		{
			var result=_animalCategoryService.GetAll();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest();
		}

		[HttpPost("Add")]
		public IActionResult Add(AnimalCategory animalCategory)
		{
			
			var result = _animalCategoryService.Add(animalCategory);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest();
		}

		[HttpPost("Delete")]
		public IActionResult Delete(AnimalCategory animalCategory)
		{
			var result = _animalCategoryService.Delete(animalCategory);
				if (result.Success) { 
				return Ok(result);
			}
			return BadRequest();
		}

		[HttpPost("Update")]
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
