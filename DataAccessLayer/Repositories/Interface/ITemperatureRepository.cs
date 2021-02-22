using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interface
{
    public interface ITemperatureRepository
    {
        Task<List<Temperature>> GetAllTemperatures();
        Task<Temperature> InsertTemperatureRecord(Temperature temperature);
        Task<Temperature> GetTemperatureById(int id);
    }
}
