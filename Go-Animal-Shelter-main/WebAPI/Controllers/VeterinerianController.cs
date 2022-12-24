using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinerianController : ControllerBase
    {
        IVeterinerianService _veterinerian;
        public VeterinerianController(IVeterinerianService veterinerian)
        {
            _veterinerian = veterinerian;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll() { 
            var result = _veterinerian.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("Add")]
        public IActionResult Add(Veterinerian veterinerian)
        {
            var result = _veterinerian.Add(veterinerian);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("Delete")]
        public IActionResult Delete(Veterinerian veterinerian)
        {
            var result = _veterinerian.Delete(veterinerian);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("Update")]
        public IActionResult Update(Veterinerian veterinerian)
        {
            var result = _veterinerian.Update(veterinerian);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
