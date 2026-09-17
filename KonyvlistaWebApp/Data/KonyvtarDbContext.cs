using Microsoft.EntityFrameworkCore;
using KonyvlistaWebApp.Models;

namespace KonyvlistaWebApp.Data;

public class KonyvtarDbContext : DbContext
{
    public KonyvtarDbContext(DbContextOptions<KonyvtarDbContext> options) :base(options)
    {
        
    }

    public DbSet<Konyv> Konyvek {get; set; }    
}