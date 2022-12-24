﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Go_Animal_Shelter.Controllers
{
    public class ServiceTableController : Controller
    {
        ServiceManager serviceManager=new ServiceManager(new EfServiceDal());
        [HttpGet]
        public IActionResult Index()
        {
            var result = serviceManager.GetAll();
            return View(result.Data);
        }

        [HttpGet]
        public IActionResult List()
        {
            var result = serviceManager.GetAll();
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
        public IActionResult Add(Service service) { 
                var result = serviceManager.Add(service);
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
        public IActionResult Update(Service service)
        {
            var result = serviceManager.Update(service);
            if (result.Success)
            {
                return RedirectToAction("List");
            }
            return View();

        }
        
        public IActionResult Delete(int id,Service service)
        {
           serviceManager.Delete(service);
           return RedirectToAction("List");          
        }

    }
}