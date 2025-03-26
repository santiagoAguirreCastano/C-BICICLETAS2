using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.Show();

        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
            Facturas facturas = new Facturas();
            facturas.Show();
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial();
            historial.Show();
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();
            empleados.Show();
        }
    }
}
