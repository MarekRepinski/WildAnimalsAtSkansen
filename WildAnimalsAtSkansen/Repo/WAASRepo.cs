using Microsoft.EntityFrameworkCore;
using WildAnimalsAtSkansen.DTOs;
using WildAnimalsAtSkansen.Entities;

namespace WildAnimalsAtSkansen.Repo
{
    public class WAASRepo : IWAASRepo
    {
        private ApplicationContext _context;

        public WAASRepo(ApplicationContext context)
        {
            _context = context;
        }

        public List<AnimalDTO> GetAnimalAll()
        {
            return AnimalDTO.GetAnimalDTOs(_context).ToList();
        }

        public AnimalDTO GetAnimalById(int id)
        {
            return AnimalDTO.GetAnimalDTO(_context, id).ToList()[0];
        }

        public List<AnimalDTO> GetAnimalByName(string name)
        {
            return AnimalDTO.GetAnimalNameDTOs(_context, name).ToList();
        }

        public Animal CreateAnimal(CreateAnimalDTO dto)
        {
            Animal animal = new Animal();
            animal.AnimalTypeId = dto.AnimalTypeId;
            animal.HabitatId = dto.HabitatId;
            animal.Name = dto.Name;
            animal.LatinName = dto.LatinName;
            animal.FamilyName = dto.FamilyName;
            animal.AgeExpectancyYears = dto.AgeExpectancyYears;
            animal.Description = dto.Description;

            _context.Animal.Add(animal);
            _context.SaveChanges();

            return animal;
        }

        public Animal UpdateAnimal(CreateAnimalDTO animal, int id)
        {
            Animal existingAnimal = _context.Animal.SingleOrDefault(x => x.AnimalId == id);
            if (existingAnimal is not null)
            {
                existingAnimal.AnimalTypeId = animal.AnimalTypeId;
                existingAnimal.HabitatId = animal.HabitatId;
                existingAnimal.Name = animal.Name;
                existingAnimal.LatinName = animal.LatinName;
                existingAnimal.FamilyName = animal.FamilyName;
                existingAnimal.AgeExpectancyYears = animal.AgeExpectancyYears;
                existingAnimal.Description = animal.Description;
                _context.SaveChanges(true);
            }
            return existingAnimal;
        }

        public bool DeleteAnimalById(int id)
        {
            Animal animal = _context.Animal.SingleOrDefault(x => x.AnimalId == id);
            if (animal is null)
            {
                return false;
            }
            _context.Animal.Remove(animal);
            _context.SaveChanges(true);
            return true;
        }

        public List<AnimalDTO> GetHabitatAnimalsById(int id)
        {
            return _context
                .Animal
                .Include(v => v.animalType)
                .Include(v => v.Habitat)
                .Where(x => x.HabitatId == id)
                .ToList()
                .MapToAnimalDTOs();
        }

        public List<AnimalDTO> GetAnimalTypeAnimalsById(int id)
        {
            return _context
                .Animal
                .Include(v => v.animalType)
                .Include(v => v.Habitat)
                .Where(x => x.AnimalTypeId == id)
                .ToList()
                .MapToAnimalDTOs();
        }
    }
}
