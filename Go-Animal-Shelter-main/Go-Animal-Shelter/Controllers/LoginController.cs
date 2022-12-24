using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Go_Animal_Shelter.Controllers
{
	public class LoginController : Controller
	{
		AuthManager authManager = new AuthManager(new UsersManager(new EfUsersDal()));
		UsersManager userManager= new UsersManager(new EfUsersDal());
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Login(UserLoginDto userLoginDto)
		{
			var user=authManager.Login(userLoginDto);
			if (user.Data!=null)
			{
				return RedirectToAction("Index", "Admin");
				


			}
			return RedirectToAction("Index", "Login");

			
			
		}
	}
}
