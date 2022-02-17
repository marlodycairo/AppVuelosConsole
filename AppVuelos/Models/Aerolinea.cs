using System.Collections.Generic;

namespace AppVuelos.Models
{
    public class Aerolinea
    {
        public int AerolineaId { get; set; }
        public string NombreAerolinea { get; set; }
        public List<string> VueloAerolinea { get; set; }
    }
}
