using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Go_Animal_Shelter.Controllers
{
	public class RegisterController : Controller
	{
		AuthManager authManager = new AuthManager(new UsersManager(new EfUsersDal()));
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Register(UserRegisterDto userRegisterDto,string password)
		{
			var isUserExists = authManager.UserExists(userRegisterDto.Email);
			var result=authManager.Register(userRegisterDto,password);
			if (isUserExists.Success)
			{
				return View("Index");
			}
			return View("/Home");

		}
	}
}
