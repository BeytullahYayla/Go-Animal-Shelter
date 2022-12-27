using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Go_Animal_Shelter.Controllers
{
    public class PetController : Controller
    {
        PetManager petManager = new PetManager(new EfPetDal());

        [HttpGet]
        public IActionResult Index()
        {
            var pets=petManager.GetAll();

            return View(pets.Data);
        }
    }
}
