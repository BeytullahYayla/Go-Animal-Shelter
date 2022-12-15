using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServiceControllerr : ControllerBase
	{
		IServiceService _serviceService;
		public ServiceControllerr(IServiceService serviceService)
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
			else
			{
				return BadRequest();
			}
		
		}
		[HttpPost("Add")]
		public IActionResult Add(Service service)
		{

			var result=_serviceService.Add(service);
			if (result.Success)
			{
				return Ok(result);
			}
			else
			{
				return BadRequest();
			}

		}
	}
}
