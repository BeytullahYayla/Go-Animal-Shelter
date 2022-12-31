using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Go_Animal_Shelter.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AnimalCategoryTable : Controller
    {
        AnimalCategoryManager animalCategoryManager = new AnimalCategoryManager(new EfAnimalCategoryDal());
        public async Task<IActionResult> Index()
        {
            var httpClient=new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:7038/api/AnimalCategory/GetAll");
            var jsonString =await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<Root>(jsonString);
            return View(values.data);
        }
    }
    public class Datum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Pet> pets { get; set; }
    }

    public class Root
    {
        public List<Datum> data { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
    }
}
