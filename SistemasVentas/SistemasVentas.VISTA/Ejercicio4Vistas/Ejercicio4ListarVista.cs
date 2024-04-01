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

namespace SistemasVentas.VISTA.Ejercicio4Vistas
{
    public partial class Ejercicio4ListarVista : Form
    {
        public Ejercicio4ListarVista()
        {
            InitializeComponent();
        }

        ProductoBss bss = new ProductoBss();
        private void Ejercicio4ListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductosBss();
        }
    }
}
