using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<DatosClimaticos> DatosClimaticos { get; set; }

        public int PaisId { get; set; }
        public Pais Pais { get; set; }
    }
}