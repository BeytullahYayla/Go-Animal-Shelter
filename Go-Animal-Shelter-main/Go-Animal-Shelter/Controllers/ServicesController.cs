using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Go_Animal_Shelter.Controllers
{
	public class ServicesController : Controller
	{
		ServiceManager serviceManager=new ServiceManager(new EfServiceDal());
		public async Task<IActionResult> Index()
		{
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:7038/api/Service/GetAll");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ServiceRoot>(jsonString);
            return View(values.data);
            
		}
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class ServiceDto
        {
            public int serviceId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
        }

        public class ServiceRoot
        {
            public List<ServiceDto> data { get; set; }
            public bool success { get; set; }
            public string message { get; set; }
        }


        public IActionResult GetAll()
		{
			var results=serviceManager.GetAll()
;			return View(results.Data);
		}
	}
}
