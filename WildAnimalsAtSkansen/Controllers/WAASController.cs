using Microsoft.AspNetCore.Mvc;
using WildAnimalsAtSkansen.DTOs;
using WildAnimalsAtSkansen.Entities;
using WildAnimalsAtSkansen.Repo;

namespace WildAnimalsAtSkansen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class WAASController : ControllerBase
    {
        private readonly IWAASRepo _repo;
        public WAASController(IWAASRepo repo)
        {
            _repo = repo;
        }
        
        [HttpGet("Animals")]
        public IActionResult GetAnimalAll()
        {
            List<AnimalDTO> animals = _repo.GetAnimalAll();
            if (animals is null)
            {
                return NotFound("All animal has run away!!");
            }
            return Ok(animals);
        }

        [HttpGet("Animal/{name}")]
        public IActionResult GetAnimal(string name)
        {
            if (int.TryParse(name, out int id))
            {
                AnimalDTO aDto = _repo.GetAnimalById(id);
                if (aDto is null)
                {
                    return NotFound("Could not find Animal with ID " + id);
                }
                return Ok(aDto);
            }
            List<AnimalDTO> aDtos = _repo.GetAnimalByName(name);
            if (aDtos is null)
            {
                return NotFound("Could not find Animals with name of " + name);
            }
            return Ok(aDtos);
        }

        [HttpGet("AnimalType/{id}")]
        public IActionResult GetAnimalType(int id)
        {
            List<AnimalDTO> atDto = _repo.GetAnimalTypeAnimalsById(id);
            if (atDto is null)
            {
                return NotFound("Could not find AnimalType with ID " + id);
            }
            return Ok(atDto);
        }
        [HttpGet("Habitat/{id}")]
        public IActionResult GetHabitat(int id)
        {
            List<AnimalDTO> atDto = _repo.GetHabitatAnimalsById(id);
            if (atDto is null)
            {
                return NotFound("Could not find Habitat with ID " + id);
            }
            return Ok(atDto);
        }
    }
}
