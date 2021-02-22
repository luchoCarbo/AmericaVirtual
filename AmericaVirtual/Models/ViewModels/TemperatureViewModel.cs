using AmericaVirtual.Dtos;
using AmericaVirtual.Models.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmericaVirtual.Models.ViewModels
{
    public class TemperatureViewModel : ITemperatureViewModel
    {
        public List<TemperatureDto> TemperatureDtoList { get; set; } = new List<TemperatureDto>();

        public void AddTemperatureDtoList(List<TemperatureDto> temperatureDtos)
        {
            TemperatureDtoList.AddRange(temperatureDtos);
        }
    }
}
