using Microsoft.EntityFrameworkCore;
using Openlayers_backend.Models;

namespace proje_deneme.Controllers
{
    public class LocationDbContext : DbContext
    {
        public LocationDbContext(DbContextOptions<LocationDbContext> options) : base(options)
        {

        }
        public DbSet<Location> Locations { get; set; }

    }
}
