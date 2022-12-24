using Microsoft.AspNetCore.Mvc;

namespace Go_Animal_Shelter.Controllers
{
	public class GalleryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
