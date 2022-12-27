using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Go_Animal_Shelter.Controllers
{
    public class UserRoleTableController : Controller
    {
        OperationClaimManager operationClaimManager = new OperationClaimManager(new EfOperationClaimDal());
        [HttpGet]
        public IActionResult Index()
        {

            var values=operationClaimManager.GetUserOperationClaims();
            return View(values);
        }

       

        
    }
}
