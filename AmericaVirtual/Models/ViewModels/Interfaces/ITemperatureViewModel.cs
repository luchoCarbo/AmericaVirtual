using AmericaVirtual.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmericaVirtual.Models.ViewModels.Interfaces
{
    public interface ITemperatureViewModel
    {
        public List<TemperatureDto> TemperatureDtoList { get; set; }
        void AddTemperatureDtoList(List<TemperatureDto> temperatureDtos);
    }
}
