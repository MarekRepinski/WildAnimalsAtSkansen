using System.ComponentModel.DataAnnotations;

namespace WildAnimalsAtSkansen.Entities
{
    public class AnimalType
    {
        [Key]
        public int AnimalTypeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ICollection<Animal> Animals { get; set; }
    }
}
