using Microsoft.EntityFrameworkCore;
using PlasmanShovels.Models;

namespace PlasmanShovels.Data
{
    public class PlasmanShovelsContext : DbContext
    {
        public PlasmanShovelsContext(DbContextOptions<PlasmanShovelsContext> options)
            : base(options)
        {
        }

        public DbSet<Shovel> Shovel { get; set; }
    }
}