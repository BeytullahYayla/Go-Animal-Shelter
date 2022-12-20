using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Go_Animal_Shelter.Controllers
{
	public class ServicesController : Controller
	{
		ServiceManager serviceManager=new ServiceManager(new EfServiceDal());
		public IActionResult Index()
		{
			var results = serviceManager.GetAll();
			return View(results.Data);
		}

		
		public IActionResult GetAll()
		{
			var results=serviceManager.GetAll()
;			return View(results.Data);
		}
	}
}
