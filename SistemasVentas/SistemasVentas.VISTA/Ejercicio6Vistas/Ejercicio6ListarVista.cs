using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.Ejercicio6Vistas
{
    public partial class Ejercicio6ListarVista : Form
    {
        public Ejercicio6ListarVista()
        {
            InitializeComponent();
        }

        DetalleVentaBss bss = new DetalleVentaBss();
        private void Ejercicio6ListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductosVendidosXVendedorBss();
        }
    }
}
