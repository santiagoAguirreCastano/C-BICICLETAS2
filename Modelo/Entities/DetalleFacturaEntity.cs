using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class DetalleFacturaEntity
    {
        public int IdFactura_IdProducto { get; set; }

        public int IdFactura { get; set; }

        public int IdProducto { get; set; }

        public int CantidadProducto { get; set; }

        public int PrecioProducto { get; set; }

        public int Total { get; set; }  
    }
}
