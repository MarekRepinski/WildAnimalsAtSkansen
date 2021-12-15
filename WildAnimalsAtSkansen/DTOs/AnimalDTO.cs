using WildAnimalsAtSkansen.Entities;

namespace WildAnimalsAtSkansen.DTOs
{
    public class AnimalDTO
    {
        public string Name { get; set; }
        public string LatinName { get; set; }
        public string FamilyName { get; set; }
        public string AnimalType { get; set; }
        public string Habitat { get; set; }
        public string Description { get; set; }
        public int AgeExpectancyYears { get; set; }

        public static IQueryable<AnimalDTO> GetAnimalDTO(ApplicationContext DBContext, int id)
        {
            return (IQueryable<AnimalDTO>)(
                from a in DBContext.Animal
                join at in DBContext.AnimalType on a.AnimalTypeId equals at.AnimalTypeId
                join h in DBContext.Habitat on a.HabitatId equals h.HabitatId
                where a.AnimalId == id
                select new AnimalDTO
                {
                    Name = a.Name,
                    LatinName = a.LatinName,
                    FamilyName = a.FamilyName,
                    AnimalType = at.Name,
                    Habitat = h.Name,
                    Description = a.Description,
                    AgeExpectancyYears = a.AgeExpectancyYears,
                });
        }

        public static IQueryable<AnimalDTO> GetAnimalDTOs(ApplicationContext DBContext)
        {
            return (IQueryable<AnimalDTO>)(
                from a in DBContext.Animal
                join at in DBContext.AnimalType on a.AnimalTypeId equals at.AnimalTypeId
                join h in DBContext.Habitat on a.HabitatId equals h.HabitatId
                select new AnimalDTO
                {
                    Name = a.Name,
                    LatinName = a.LatinName,
                    FamilyName = a.FamilyName,
                    AnimalType = at.Name,
                    Habitat = h.Name,
                    Description = a.Description,
                    AgeExpectancyYears = a.AgeExpectancyYears,
                });
        }
        public static IQueryable<AnimalDTO> GetAnimalNameDTOs(ApplicationContext DBContext, string name)
        {
            return (IQueryable<AnimalDTO>)(
                from a in DBContext.Animal
                join at in DBContext.AnimalType on a.AnimalTypeId equals at.AnimalTypeId
                join h in DBContext.Habitat on a.HabitatId equals h.HabitatId
                where a.Name.StartsWith(name)
                select new AnimalDTO
                {
                    Name = a.Name,
                    LatinName = a.LatinName,
                    FamilyName = a.FamilyName,
                    AnimalType = at.Name,
                    Habitat = h.Name,
                    Description = a.Description,
                    AgeExpectancyYears = a.AgeExpectancyYears,
                });
        }
    }

    public static class AnimalDTOExtensions
    {
        public static AnimalDTO MapToAnimalDTO(this Animal dto)
        {
            return new AnimalDTO
            {
                Name = dto.Name,
                LatinName = dto.LatinName,
                FamilyName = dto.FamilyName,
                AnimalType = dto.animalType.Name,
                Habitat = dto.Habitat.Name,
                Description = dto.Description,
                AgeExpectancyYears = dto.AgeExpectancyYears,
            };
        }
        public static List<AnimalDTO> MapToAnimalDTOs(this List<Animal> animals)
        {
            return animals.Select(a => a.MapToAnimalDTO()).ToList();
        }
    }
}
