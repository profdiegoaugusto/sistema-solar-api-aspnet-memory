using Microsoft.EntityFrameworkCore;

namespace SistemaSolarApi.Models
{
    public class PlanetaContext : DbContext
    {
        public PlanetaContext(DbContextOptions<PlanetaContext> options)
            : base(options)
        {
        }

        public DbSet<Planeta> Planetas { get; set; } = null!;
    }
}

