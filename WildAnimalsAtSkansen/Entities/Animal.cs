using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WildAnimalsAtSkansen.Entities
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }

        public int AnimalTypeId { get; set; }
        [ForeignKey("AnimalTypeId")]
        public AnimalType animalType { get; set; }

        public int HabitatId { get; set; }
        [ForeignKey("HabitatId")]
        public Habitat Habitat { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string LatinName { get; set; }
        [Required]
        public string FamilyName { get; set; }
        [Required]
        public int AgeExpectancyYears { get; set; }
        [Required]
        public string Description { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
