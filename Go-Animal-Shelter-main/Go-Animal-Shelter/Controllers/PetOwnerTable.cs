using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Go_Animal_Shelter.Controllers
{
    public class PetOwnerTable : Controller
    {
        PetOwnerManager petOwnerManager = new PetOwnerManager(new EfPetOwnerDal());
        [HttpGet]
        public IActionResult Index()
        {
            var result=petOwnerManager.GetAll();
           
            return View(result.Data);
        }
    }
}
