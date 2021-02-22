using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayerAPI.Services.Interfaces
{
    public interface ITemperatureService
    {
        Task<List<Temperature>> GetTemperatureList();
        Task InsertTemperatureRecord(Temperature temperature);
        Task<Temperature> GetTemperatureById(int id);
    }
}
