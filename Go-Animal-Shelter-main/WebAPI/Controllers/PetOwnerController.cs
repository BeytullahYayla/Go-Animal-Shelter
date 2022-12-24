using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetOwnerController : ControllerBase
    {
        IPetOwnerService _petOwnerService;

        public PetOwnerController(IPetOwnerService petOwnerService)
        {
            _petOwnerService = petOwnerService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll() {

            var result = _petOwnerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        
        }
        [HttpPost("Add")]
        public IActionResult Add(PetOwner petOwner)
        {
            var result = _petOwnerService.Add(petOwner);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("Delete")]
        public IActionResult Delete(PetOwner petOwner)
        {
            var result = _petOwnerService.Delete(petOwner);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("Update")]
        public IActionResult Update(PetOwner petOwner)
        {
            var result = _petOwnerService.Update(petOwner);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _petOwnerService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
