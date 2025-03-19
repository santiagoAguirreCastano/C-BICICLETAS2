using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class ProductosEntity
    {
        public int IdProducto { get; set; }

        public string NombreProducto { get; set; }

        public string DescripcionProducto {  get; set; }

        public int PrecioProducto { get; set; }

        public int CantidadProducto {  get; set; }

        public string TipoProducto {  get; set; }


    }
}
