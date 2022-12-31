using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace Go_Animal_Shelter.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PetOwnerTable : Controller
    {
        PetOwnerManager petOwnerManager = new PetOwnerManager(new EfPetOwnerDal());
        Context context = new Context();
        [HttpGet]

        public IActionResult Index()
        {
            var result = petOwnerManager.GetAll().Data;

            return View(result);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(PetOwner petOwner)
        {
            var result = petOwnerManager.Add(petOwner);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Entities.Concrete.PetOwner petOwner)
        {
            var result = petOwnerManager.Update(petOwner);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        
        public IActionResult Delete(int id,PetOwner petOwner)
        {
            ;
            petOwnerManager.Delete(petOwner);
            return RedirectToAction("Index");
        }
    }
}
