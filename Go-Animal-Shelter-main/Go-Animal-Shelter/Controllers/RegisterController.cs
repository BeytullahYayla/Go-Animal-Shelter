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
		UserOperationClaimManager userOperationClaimManager=new UserOperationClaimManager(new EfUserOperationClaimDal());
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Register(UserRegisterDto userRegisterDto,string password)
		{


			if (ModelState.IsValid)
			{
			var isUserExists = authManager.UserExists(userRegisterDto.Email);
			var result=authManager.Register(userRegisterDto,password);
                if (!isUserExists.Success)
                {

                    UserOperationClaim userOperationClaim = new UserOperationClaim();
                    //Sisteme eklenen kullanıcının rolü otomatik olarak user olarak atanır.
                    userOperationClaim.UserID = result.Data.UserID;
                    userOperationClaim.OperationClaimID = 2;
                    userOperationClaimManager.Add(userOperationClaim);
                    return View("Index");


                }
            }
			
			return View("Index");

		}
	}
}
