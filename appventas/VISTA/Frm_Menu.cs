using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas.VISTA
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public static FrmVenta frmVenta = new FrmVenta();
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto buscar = new FrmProducto();
            frmVenta.Show();
        }
    }
}
