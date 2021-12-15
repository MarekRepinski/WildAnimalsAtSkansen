namespace WildAnimalsAtSkansen.DTOs
{
    public class CreateAnimalDTO
    {
        public int AnimalTypeId { get; set; }
        public int HabitatId { get; set; }
        public string Name { get; set; }
        public string LatinName { get; set; }
        public string FamilyName { get; set; }
        public int AgeExpectancyYears { get; set; }
        public string Description { get; set; }
    }
}
