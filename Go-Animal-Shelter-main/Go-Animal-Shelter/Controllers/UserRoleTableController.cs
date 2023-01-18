using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Go_Animal_Shelter.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserRoleTableController : Controller
    {
        OperationClaimManager operationClaimManager = new OperationClaimManager(new EfOperationClaimDal());
        [HttpGet]
        public IActionResult Index()
        {

            var values=operationClaimManager.GetUserOperationClaims();
            return View(values);
        }
        public IActionResult Update()
        {
            return View();
        }


       

        
    }
}
