using Microsoft.AspNetCore.Mvc;

namespace Go_Animal_Shelter.Controllers
{
	public class VeterinerianController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
