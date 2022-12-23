using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Go_Animal_Shelter.Controllers
{
    public class ContactTableController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            var result = contactManager.GetAll();
            if (result.Success)
            {
                return View(result.Data);
            }
            return View("Index");

        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            var result = contactManager.Add(contact);
            if (result.Success)
            {
                return RedirectToAction("List");
            }
            return View();

        }

        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Contact contact)
        {
            var result = contactManager.Update(contact);
            if (result.Success)
            {
                return RedirectToAction("List");
            }
            return View();
        }
        public IActionResult Delete(int id, Contact contact)
        {
            contactManager.Delete(contact);
            return RedirectToAction("List");
        }
    }
}
