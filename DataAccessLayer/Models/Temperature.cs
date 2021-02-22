using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Models
{
    public class Temperature
    {
        public int Id { get; set; }
        public string TemperatureInCelcius { get; set; }
        public DateTime DateRegistered { get; set; }
    }
}
