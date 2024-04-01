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

namespace SistemasVentas.VISTA.Ejercicio3Vistas
{
    public partial class Ejercicio3ListarVista : Form
    {
        public Ejercicio3ListarVista()
        {
            InitializeComponent();
        }
        
        DetalleVentaBss bss = new DetalleVentaBss();    
        private void Ejercicio3ListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarDetallesVentaBss();
        }
    }
}
