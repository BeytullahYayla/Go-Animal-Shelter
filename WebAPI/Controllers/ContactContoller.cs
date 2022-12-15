using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactContoller : ControllerBase
    {
        IContactService _contactService;
        public ContactContoller(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            var result= _contactService.Add(contact);
            if (result.Success)
            {
                return Ok(result);
            }            
                return BadRequest();   
        }
        [HttpPost]
        public IActionResult Remove(Contact contact) {
            var result= _contactService.Remove(contact);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost]
        public IActionResult Update(Contact contact) {
            var result=_contactService.Update(contact);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet]
        public IActionResult GetAll() {
            var result = _contactService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return Ok(result);
        }
    }
}
