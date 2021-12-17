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
            if (aDtos.Count == 0)
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

        [HttpPost("")]
        public IActionResult CreateAnimal([FromBody] CreateAnimalDTO createAnimalDTO)
        {
            Animal createdAnimal = _repo.CreateAnimal(createAnimalDTO);

            AnimalDTO aDto = _repo.GetAnimalById(createdAnimal.AnimalId);

            return CreatedAtAction(nameof(GetAnimal), new { name = createdAnimal.AnimalId }, aDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAnimal(int id)
        {
            if (_repo.DeleteAnimalById(id))
            {
                return NoContent();
            }
            return NotFound("Could not find Animal with ID " + id);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAnimal([FromBody] CreateAnimalDTO animal, int id)
        {
            Animal updatedAnimal = _repo.UpdateAnimal(animal, id);
            if (updatedAnimal is null)
            {
                return NotFound("Could not find Animal with ID " + id);
            }
            AnimalDTO aDto = _repo.GetAnimalById(id);
            return Ok(aDto);
        }
    }
}
