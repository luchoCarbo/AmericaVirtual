using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Models.EFModel
{
    public class TemperatureContextFactory : IDesignTimeDbContextFactory<TemperatureContext>
    {
        public TemperatureContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TemperatureContext>();
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=temperature;Trusted_Connection=True;");

            return new TemperatureContext(optionsBuilder.Options);
        }
    }
}
