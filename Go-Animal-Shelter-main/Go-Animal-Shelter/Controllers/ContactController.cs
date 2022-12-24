using Microsoft.AspNetCore.Mvc;

namespace Go_Animal_Shelter.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
