using WildAnimalsAtSkansen.DTOs;
using WildAnimalsAtSkansen.Entities;

namespace WildAnimalsAtSkansen.Repo
{
    public interface IWAASRepo
    {
        List<AnimalDTO> GetAnimalAll();
        AnimalDTO GetAnimalById(int id);
        List<AnimalDTO> GetAnimalByName(string name);
        
        AnimalDTO CreateAnimal(AnimalDTO dto);
        AnimalDTO UpdateAnimal(AnimalDTO dto);
        void DeleteAnimalById(int id);
        List<AnimalDTO> GetHabitatAnimalsById(int id);
        List<AnimalDTO> GetAnimalTypeAnimalsById(int id);
    }
}
