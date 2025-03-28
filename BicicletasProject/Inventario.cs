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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProductos agregarProductos = new AgregarProductos();
            agregarProductos.Show();
            Inventario inventario = new Inventario();


        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
