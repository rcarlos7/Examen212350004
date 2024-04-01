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

namespace SistemasVentas.VISTA.Ejercicio9Vistas
{
    public partial class Ejercicio9ListarVista : Form
    {
        public Ejercicio9ListarVista()
        {
            InitializeComponent();
        }
         TipoProdBss bss = new TipoProdBss();
        private void Ejercicio9ListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarTipoProdsBass();
        }
    }
}
