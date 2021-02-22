using AmericaVirtual.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AmericaVirtual.Utilities
{
    public static class ApiCommunication
    {
        const string BASE_URL = "https://localhost:44348";
        private static HttpClient httpClient = new HttpClient();

        public async static Task<List<TemperatureDto>> getTemperatureList() 
        {
            var temperatureList = await JsonSerializatorHelper<TemperatureDto>.GetJsonListFromContent($"{BASE_URL}/api/Temperature", httpClient);
            return temperatureList;
        }

        public async static Task<TemperatureDto> getTemperatureById(int id)
        {
            var selectedTemperature = await JsonSerializatorHelper<TemperatureDto>.GetJsonFromContent($"{BASE_URL}/api/Temperature/{id}", httpClient);
            return selectedTemperature;
        }
    }
}
