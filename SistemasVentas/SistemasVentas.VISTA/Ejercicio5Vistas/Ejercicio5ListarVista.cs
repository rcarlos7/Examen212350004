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

namespace SistemasVentas.VISTA.Ejercicio5Vistas
{
    public partial class Ejercicio5ListarVista : Form
    {
        public Ejercicio5ListarVista()
        {
            InitializeComponent();
        }

        ProductoBss bss = new ProductoBss();
        private void Ejercicio5ListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductosXVencerBss();
        }
    }
}
