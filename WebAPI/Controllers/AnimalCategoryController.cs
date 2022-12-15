using Business.Abstract;
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
		
	}
}
