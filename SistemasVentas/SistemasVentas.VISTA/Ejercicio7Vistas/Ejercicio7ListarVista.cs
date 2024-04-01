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

namespace SistemasVentas.VISTA.Ejercicio7Vistas
{
    public partial class Ejercicio7ListarVista : Form
    {
        public Ejercicio7ListarVista()
        {
            InitializeComponent();
        }

        ClienteBss bss = new ClienteBss();
        private void Ejercicio7ListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarIngresoClientesBss();
        }
    }
}
