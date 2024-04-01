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

namespace SistemasVentas.VISTA.Ejercicio2Vistas
{
    public partial class Ejercicio2ListarVista : Form
    {
        public Ejercicio2ListarVista()
        {
            InitializeComponent();
        }
        
        IngresoBss bss = new IngresoBss();
        private void Ejercicio2ListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarIngresosBss();
        }
    }
}
