using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductosController productoController = new ProductosController();

            var productos = productoController.verProductos();
            string resultado = "";
            foreach (var product in productos)
            {
                resultado += "Nombre: " + product.nombre_producto + " Descripcion: " + product.descripcion + " Precio: " + product.precio_producto + " Cantidad: " + product.cantidad_producto + " Tipo: " + product.tipo_producto + "\n";
            }
            lblResultadoProductos.Text = resultado;
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ProductosController productosController = new ProductosController();
            string resultado = productosController.guardarProductos(txtNombre.Text, txtDescripcion.Text, Convert.ToInt32(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text), txtTipo.Text);
            lblResultadoProducto2.Text = resultado;
        }


        
    }
}
