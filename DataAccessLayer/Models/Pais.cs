using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Ciudad> Ciudades { get; set; }
    }
}
