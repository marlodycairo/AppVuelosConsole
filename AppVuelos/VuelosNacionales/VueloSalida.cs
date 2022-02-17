using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVuelos.VuelosNacionales
{
    public class VueloSalida
    {
        public int Id { get; set; }
        public string VueloId { get; set; }
        public DateTime FechaVuelo { get; set; }
        public int CiudadDestino { get; set; }
        public int VueloLlegadaId { get; set; }
    }
}
