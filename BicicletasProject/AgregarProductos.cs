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
    public partial class AgregarProductos : Form
    {
        public AgregarProductos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ProductosController productosController = new ProductosController();
            string resultado = productosController.guardarProductos(txtNombre.Text, txtDescripcion.Text, Convert.ToInt32(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text), txtTipo.Text);
            lblResultadoProducto2.Text = resultado;
        }


        
    }
}
