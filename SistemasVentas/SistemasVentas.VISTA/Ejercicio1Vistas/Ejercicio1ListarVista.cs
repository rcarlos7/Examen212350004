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

namespace SistemasVentas.VISTA.Ejercicio1Vistas
{
    public partial class Ejercicio1ListarVista : Form
    {
        public Ejercicio1ListarVista()
        {
            InitializeComponent();
        }

        ClienteBss bss =  new ClienteBss();
        private void Ejercicio1ListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClientesBss();
        }
    }
}
