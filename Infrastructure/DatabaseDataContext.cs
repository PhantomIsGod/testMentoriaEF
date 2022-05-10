using Microsoft.EntityFrameworkCore;
using testMentoriaEF.Model;

namespace testMentoriaEF.Infrastructure
{
    public class DatabaseDataContext : DbContext
    {
        public DatabaseDataContext(DbContextOptions<DatabaseDataContext> options) : base(options)
        {

        }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
