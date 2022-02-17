using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVuelos.Models
{
    public class Tiquetes
    {
        public int TiqueteId { get; set; }
        public int AerolineaId { get; set; }
        public string NumeroVuelo { get; set; }
        public int ClienteId { get; set; }
        public int CiudadOrigenId { get; set; }
        public int CiudadDestinoId { get; set; }
        public DateTime? FechaCompra { get; set; }
        public DateTime? FechaVuelo { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal Total
        {
            get => total = Convert.ToDecimal(ValorUnitario * Cantidad);
            set => total = value;
        }
        private decimal total;
    }
}
