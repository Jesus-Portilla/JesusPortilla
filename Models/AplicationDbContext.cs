using Microsoft.EntityFrameworkCore;

namespace JesusPortilla.Models
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
