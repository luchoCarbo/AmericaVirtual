using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmericaVirtual.Dtos
{
    public class TemperatureDto
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "temperatureInCelcius")]
        public string TemperatureInCelcius { get; set; }
        [JsonProperty(PropertyName = "dateRegistered")]
        public string DateRegistered { get; set; }
    }
}
