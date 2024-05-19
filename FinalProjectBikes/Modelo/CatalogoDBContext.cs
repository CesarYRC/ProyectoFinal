using Microsoft.EntityFrameworkCore;

namespace FinalProjectBikes.Modelo
{
    public class CatalogoDBContext : DbContext
    {
        public CatalogoDBContext(DbContextOptions<CatalogoDBContext> options) : base(options)
        { 
        }
        public DbSet<Proveedor> cliente { get; set; }
        public DbSet<Proveedor> proveedor { get; set; }
    }
}
