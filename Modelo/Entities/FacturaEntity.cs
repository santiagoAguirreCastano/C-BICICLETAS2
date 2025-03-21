using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class FacturaEntity
    {

        public int idFactura { get; set; }
        public string FechaFactura { get; set; }

        public int TotalFactura { get; set; }

        public string TipoFactura { get; set; }

        public int IdCliente { get; set; }

        public int IdVendedor { get; set; }

        public int IdProveedor { get; set; }
    }
}
