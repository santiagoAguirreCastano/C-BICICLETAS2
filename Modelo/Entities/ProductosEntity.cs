using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class ProductosEntity
    {
        public int idproducto { get; set; }

        public string nombre_producto { get; set; }

        public string descripcion {  get; set; }

        public int precio_producto { get; set; }

        public int cantidad_producto {  get; set; }

        public string tipo_producto {  get; set; }


    }
}
