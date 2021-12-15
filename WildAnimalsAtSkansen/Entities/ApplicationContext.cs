using Microsoft.EntityFrameworkCore;

namespace WildAnimalsAtSkansen.Entities
{
    // dotnet ef migrations add xxxxx
    // dotnet ef migrations remove
    // dotnet ef database update
    // dotnet watch run

    public class ApplicationContext : DbContext
    {
        public DbSet<AnimalType> AnimalType { get; set; }
        public DbSet<Habitat> Habitat{ get; set; }
        public DbSet<Animal> Animal { get; set; }

        private string _connectionString = "server=localhost;database=skansenCollection;user=admin;password=AIK4ever";
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(
                _connectionString,
                ServerVersion.AutoDetect(_connectionString));
        }
    }
}
