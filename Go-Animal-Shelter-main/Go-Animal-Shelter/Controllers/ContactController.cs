using Autofac.Core;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Go_Animal_Shelter.Controllers
{
	public class ContactController : Controller
	{
		ContactManager contactManager = new ContactManager(new EfContactDal());
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Add(Contact contact)
		{
            var result = contactManager.Add(contact);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
	}
}
