using Microsoft.EntityFrameworkCore;
namespace Test_Sabado.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }

    }
    public class PersonaDbContext : DbContext
    {
        public DbSet<Persona> Persona { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                 @"Server=localhost;Database=test;Trusted_Connection=True");
        }
    }
}
