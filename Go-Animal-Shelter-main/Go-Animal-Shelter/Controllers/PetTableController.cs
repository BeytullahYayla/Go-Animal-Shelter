using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Go_Animal_Shelter.Controllers
{
    public class PetTableController : Controller
    {

        PetManager petManager = new PetManager(new EfPetDal());
        public IActionResult Index()
        {
            var result=petManager.GetAll();
            return View(result.Data);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Pet pet)
        {
            var result = petManager.Add(pet);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Add");

        }
    }
}
