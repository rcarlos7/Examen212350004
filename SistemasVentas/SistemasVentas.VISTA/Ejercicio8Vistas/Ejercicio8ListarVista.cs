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

namespace SistemasVentas.VISTA.Ejercicio8Vistas
{
    public partial class Ejercicio8ListarVista : Form
    {
        public Ejercicio8ListarVista()
        {
            InitializeComponent();
        }

        ProveedorBss bss = new ProveedorBss();
        private void Ejercicio8ListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarIngresoProveedoresBass();
        }
    }
}
