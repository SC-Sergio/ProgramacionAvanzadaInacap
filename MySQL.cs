using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MysqlProject.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

    }

    public class PersonaContext : DbContext
    {
        public DbSet<Persona> Persona { get; set; }

        protected override void  OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySQL("server=localhost;database=dbvisualstudio;user=root;password=jajaime89");
        }
    }
}
