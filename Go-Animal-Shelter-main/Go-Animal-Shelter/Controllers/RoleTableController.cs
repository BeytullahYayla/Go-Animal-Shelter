using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Go_Animal_Shelter.Controllers
{
    public class RoleTableController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
