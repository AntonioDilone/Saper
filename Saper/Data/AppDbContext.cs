using Microsoft.EntityFrameworkCore;
using Saper.Models;

namespace Saper.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
