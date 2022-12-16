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
        IPetService _petService;
        public PetController(IPetService petService)
        {
            _petService = petService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll() {
            var result = _petService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Add")] 
        public IActionResult Add(Pet pet) {
            var result = _petService.Add(pet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Delete")]
        public IActionResult Delete(Pet pet) { 
            var result = _petService.Delete(pet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult Update(Pet pet) { 
            var result = _petService.Update(pet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}