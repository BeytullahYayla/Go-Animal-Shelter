using Business.Concrete;
using Core.Extensions;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Go_Animal_Shelter.Controllers
{
	public class LoginController : Controller
	{
		AuthManager authManager = new AuthManager(new UsersManager(new EfUsersDal()));
		UsersManager userManager= new UsersManager(new EfUsersDal());
		OperationClaimManager claimManager=new OperationClaimManager(new EfOperationClaimDal());

		private readonly IHttpContextAccessor _context;

		public LoginController(IHttpContextAccessor contextAccessor)
		{
			_context= contextAccessor;
		}

		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Login(UserLoginDto userLoginDto)
		{
			var user=authManager.Login(userLoginDto);
			var oc=this.claimManager.GetUserOperationClaims();

            if (user.Data!=null)
			{

                _context.HttpContext.Session.SetString("UserName", user.Data.FirstName + " " + user.Data.LastName);
                _context.HttpContext.Session.SetInt32("UserId", user.Data.UserID);
                List<string> roles=new List<string>();

				
                foreach (var item in oc)
				{
					if (item.UserId==user.Data.UserID)
					{
						roles.Add(item.RoleName);
                    }
				}
               
				
                var claims = userManager.GetClaims(user.Data,roles);
				
			

                var claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties();
				TempData["UserName"] = "Hello "+user.Data.FirstName;
				
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                return RedirectToAction("Index", "Admin");
                
            }

			
			return RedirectToAction("Index", "Login");
			
		}
	}
}
