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
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Login(UserLoginDto userLoginDto)
		{
			var user=authManager.Login(userLoginDto);
			if (user.Data!=null)
			{
				
                var claims = userManager.GetClaims(user.Data,this.claimManager.GetRoles());

			

                var claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties();
				
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                return RedirectToAction("Index", "Admin");
                
            }

			
			return RedirectToAction("Index", "Login");
			
		}
	}
}
