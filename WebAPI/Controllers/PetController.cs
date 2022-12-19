using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        IPetService _petservice;
        public PetController(IPetService petservice)
        {
            _petservice = petservice;
        }

        [HttpGet("GetAll")]

        public IActionResult GetAll()
        {
            var result = _petservice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut("Update")]

        public IActionResult Update(Pet pet)
        {
            var result = _petservice.Update(pet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete("Delete")]

        public IActionResult Delete(Pet pet)
        {
            var result = _petservice.Delete(pet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("Add")]

        public IActionResult Add(Pet pet)
        {
            var result = _petservice.Add(pet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("GetById")]

        public IActionResult GetById(int id)
        {
            var result = _petservice.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("GetByName")]

        public IActionResult GetByName(string name)
        {
            var result = _petservice.GetByName(name);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

    }
}
