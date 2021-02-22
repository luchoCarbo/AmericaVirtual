using System;

namespace DataAccessLayer.Models
{
    public class DatosClimaticos
    {
        public int Id { get; set; }
        public decimal GradosCelsius { get; set; }
        public decimal GradosGahrenheit { 
            get { return (GradosCelsius * 1.8m) + 32;  }
        }
        public DateTime FechaDato { get; set; }

        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }
    }
}