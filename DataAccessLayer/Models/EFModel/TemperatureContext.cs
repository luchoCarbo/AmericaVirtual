using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataAccessLayer.Models.EFModel
{
    public class TemperatureContext : DbContext
    {
        public TemperatureContext(DbContextOptions<TemperatureContext> options) : base(options)
        {
        }

        public DbSet<Temperature> Temperature { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<DatosClimaticos> DatosClimaticos { get; set; }

        
    }
}