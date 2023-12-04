using Microsoft.EntityFrameworkCore;
using Aeropuerto.Models;

namespace Aeropuerto.Context
{
    public class AplicacionContext : DbContext
    {
        public AplicacionContext(DbContextOptions<AplicacionContext> options)
        : base(options)
        {
        }

        public DbSet<hangares> Hangares { get; set; }
        public DbSet< aviones> Aviones { get; set; }
        public DbSet<pilotos > Pilotos { get; set; }
  
      
    }
}
