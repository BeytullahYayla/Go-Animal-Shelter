using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Go_Animal_Shelter.Controllers
{
    public class PetTableController : Controller
    {

        PetManager petManager = new PetManager(new EfPetDal());
        public IActionResult Index()
        {
            var result=petManager.GetPetDetails();
            return View(result.Data);
        }
    }
}
