using DataAccessLayer.Models;
using DataAccessLayer.Models.EFModel;
using DataAccessLayer.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class TemperatureRepository : ITemperatureRepository
    {
        private readonly TemperatureContext _context;

        public TemperatureRepository(TemperatureContext context)
        {
            _context = context;
        }

        public async Task<List<Temperature>> GetAllTemperatures() 
        {
            return await _context.Temperature.ToListAsync();
        }

        public async Task<Temperature> GetTemperatureById(int id)
        {
            return await _context.Temperature.FirstOrDefaultAsync(x=> x.Id == id);
        }

        public async Task InsertTemperatureRecord(Temperature temperature)
        {
            await _context.Temperature.AddAsync(temperature);
        }

        Task<Temperature> ITemperatureRepository.InsertTemperatureRecord(Temperature temperature)
        {
            throw new System.NotImplementedException();
        }
    }
}
