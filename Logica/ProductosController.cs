using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Entities;

namespace Logica
{
    public class ProductosController
    {

        public List<ProductosEntity> verProductos()
        {
            BaseDatos db = new BaseDatos();

            List<ProductosEntity> productos = db.TraerProductos();

            return productos;   
        }
        public string guardarProductos(string name, string description, int precio, int cantidad, string tipo)
        {
            string resultado = "";
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.guardarProducto(name, description, precio, cantidad, tipo);
            if (filasAfectadas > 0)
            {
                resultado = "Producto guardado";
            }
            else
            {
                resultado = "Error al guardar el producto";
            }
            return resultado;
        }
    }
   
}
