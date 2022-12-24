using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.CodeDom;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeciesController : ControllerBase
    {
        ISpeciesService _speciesService;
        public SpeciesController(ISpeciesService speciesService)
        {
            _speciesService = speciesService;
        }
        [HttpPost("Add")]
        public IActionResult Add(Species species) {
            var result = _speciesService.Add(species);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("Delete")]
        public IActionResult Delete(Species species)
        {
            var result = _speciesService.Delete(species);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("Update")]
        public IActionResult Update(Species species) {
            var result = _speciesService.Update(species);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll(Species species) { 
            var result = _speciesService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
