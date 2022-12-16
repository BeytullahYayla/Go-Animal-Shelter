using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServiceController : ControllerBase
	{
		IServiceService _serviceService;
		public ServiceController(IServiceService serviceService)
		{
			_serviceService= serviceService;
		}
	
		[HttpGet("GetAll")]
		public IActionResult GetAll() {
		
			var result=_serviceService.GetAll();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest();		
		}
		[HttpPost("Add")]
		public IActionResult Add(Service service)
		{

			var result=_serviceService.Add(service);
			if (result.Success)
			{
				return Ok(result);
			}			
			return BadRequest();
		}
		[HttpPost("Update")]
		public IActionResult Update(Service service)
		{
			var result=_serviceService.Update(service);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest();
		}

		[HttpPost("Delete")]
		public IActionResult Delete(Service service) {
			var result=_serviceService.Delete(service);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest();
		}
	}
}
