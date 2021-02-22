using BusinessLayerAPI.Services.Interfaces;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayerAPI.Services
{
    public class TemperatureService : ITemperatureService
    {
        public readonly ITemperatureRepository _temperatureRepository;

        public TemperatureService(ITemperatureRepository temperatureRepository)
        {
            _temperatureRepository = temperatureRepository;
        }

        public async Task<Temperature> GetTemperatureById(int id)
        {
            return await _temperatureRepository.GetTemperatureById(id);
        }

        public async Task<List<Temperature>> GetTemperatureList()
        {
            return await _temperatureRepository.GetAllTemperatures();
        }

        public async Task InsertTemperatureRecord(Temperature temperature)
        {
            if (!IsValidTemperatureRecord(temperature)) 
            {
                throw new ArgumentNullException("Temperature in Celsius is required");
            }

            await _temperatureRepository.InsertTemperatureRecord(temperature);
        }

        private bool IsValidTemperatureRecord(Temperature temperature) 
        {
            if (string.IsNullOrWhiteSpace(temperature.TemperatureInCelcius))
            {
                return false;
            }

            return true;
        }
    }
}
