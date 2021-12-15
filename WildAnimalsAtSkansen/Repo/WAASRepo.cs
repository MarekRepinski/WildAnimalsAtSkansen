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

        public AnimalDTO CreateAnimal(AnimalDTO dto)
        {
            throw new NotImplementedException();
        }

        public AnimalDTO UpdateAnimal(AnimalDTO dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteAnimalById(int id)
        {
            throw new NotImplementedException();
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
