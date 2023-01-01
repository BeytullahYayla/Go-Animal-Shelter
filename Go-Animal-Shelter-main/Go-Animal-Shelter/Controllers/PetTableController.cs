using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Go_Animal_Shelter.Controllers
{
    [Authorize(Roles ="Admin")]
    public class PetTableController : Controller
    {

        PetManager petManager = new PetManager(new EfPetDal());
        AnimalCategoryManager animalCategoryManager=new AnimalCategoryManager(new EfAnimalCategoryDal());
        PetOwnerManager petOwnerManager = new PetOwnerManager(new EfPetOwnerDal());
        SpeciesManager speciesManager = new SpeciesManager(new EfSpeciesDal());
            
        public IActionResult Index()
        {
            var result=petManager.GetPetDetails();
            return View(result.Data);
        }
        public IActionResult Add()
        {
            List<SelectListItem> animalCategory = (from x in animalCategoryManager.GetAll().Data
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.Id.ToString()
                                                   }

                                                 ).ToList();

            List<SelectListItem> species = (from x in speciesManager.GetAll().Data
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.Id.ToString()
                                                   }

                                                 ).ToList();
            List<SelectListItem> petowners = (from x in petOwnerManager.GetAll().Data
                                            select new SelectListItem
                                            {
                                                Text = x.FirstName+" "+x.LastName,
                                                Value =x.PetOwnerId.ToString()
                                            }

                                                 ).ToList();
            ViewBag.AnimalCategory = animalCategory;
            ViewBag.Species = species;
            ViewBag.PetOwners=petowners;
            
            return View();
        }
        [HttpPost]
        public IActionResult Add(Pet pet)
        {
            if (ModelState.IsValid)
            {
                var result = petManager.Add(pet);
                if (result.Success)
                {
                    return RedirectToAction("Index");
                }
            }
            
            return RedirectToAction("Add");

        }

        public IActionResult Update(int id)
        {
            var result = petManager.GetById(id).Data;
            List<SelectListItem> animalCategory = (from x in animalCategoryManager.GetAll().Data
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.Id.ToString()
                                                   }

                                                 ).ToList();

            List<SelectListItem> species = (from x in speciesManager.GetAll().Data
                                            select new SelectListItem
                                            {
                                                Text = x.Name,
                                                Value = x.Id.ToString()
                                            }

                                                 ).ToList();
            List<SelectListItem> petowners = (from x in petOwnerManager.GetAll().Data
                                              select new SelectListItem
                                              {
                                                  Text = x.FirstName + " " + x.LastName,
                                                  Value = x.PetOwnerId.ToString()
                                              }

                                                 ).ToList();
            ViewBag.AnimalCategory = animalCategory;
            ViewBag.Species = species;
            ViewBag.PetOwners = petowners;
            return View(result);
        }
        [HttpPost]
        public IActionResult Update(Pet pet)
        {
            var result=petManager.Update(pet);
            if (result.Success) { 
            
            return RedirectToAction("Index");
            }
            return RedirectToAction("Update");
        }

       
        public IActionResult Delete(int id,Pet pet)
        {
            var result=petManager.Delete(pet);
            return View("Index");
        }
    }
}
