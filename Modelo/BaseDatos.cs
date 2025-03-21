using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class BaseDatos: ConexionMySql
    {
        public List<ProductosEntity> TraerProductos()
        {
            List<ProductosEntity> productos = new List<ProductosEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM producto";
             MySqlDataReader dr=cmd.ExecuteReader();

            while (dr.Read())
            {
                ProductosEntity productosEntity = new ProductosEntity();
                productos.Add(productosEntity);
                productosEntity.idproducto = dr.GetInt32(0);
                productosEntity.nombre_producto = dr.GetString(5);
                productosEntity.descripcion = dr.GetString(2);
                productosEntity.precio_producto = dr.GetInt32(1);
                productosEntity.cantidad_producto = dr.GetInt32(3);
                productosEntity.tipo_producto = dr.GetString(4);


            }

            return productos;


        }
        public int guardarProducto(string Name,string Description, int Precio, int Cantidad, string Tipo)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO producto (nombre_producto,descripcion,precio_producto,cantidad_producto,tipo_producto) VALUES ('"+Name+"','"+Description+"',"+Precio+","+Cantidad+",'"+Tipo+"')";
            resultado=cmd.ExecuteNonQuery();
            return resultado;
        }
    }
}
