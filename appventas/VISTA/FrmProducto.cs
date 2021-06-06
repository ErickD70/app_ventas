using appventas.DAO;
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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }
        void Cargarventas()
        {
            Cls_Producto clsoroducto = new Cls_Producto();
            dataGridView_product.Rows.Clear();

            foreach (var listarDatos in clsoroducto.CargarProductosFiltro(textBox1.Text))
            {
                dataGridView_product.Rows.Add(listarDatos.idProducto, listarDatos.nombreProducto, listarDatos.precioProducto);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void envio()
        {
            string id = dataGridView_product.CurrentRow.Cells[0].Value.ToString();
            string Nombre = dataGridView_product.CurrentRow.Cells[1].Value.ToString();
            string Precio = dataGridView_product.CurrentRow.Cells[1].Value.ToString();

            //FrmVenta frmVenta1 = new FrmVenta();
            //frmVenta1.Txt_Id.Text = id;
            //frmVenta1.Txt_nameProduct.Text = Nombre;
            //frmVenta1.txt_precioprod.Text = Precio;
            //frmVenta1.Show();


            Frm_Menu.frmVenta.Txt_Id.Text = id;
            Frm_Menu.frmVenta.Txt_nameProduct.Text = Nombre;
            Frm_Menu.frmVenta.txt_precioprod.Text = Precio;
            Frm_Menu.frmVenta.txtcant.Focus();
            this.Close();
        }
        private void dataGridView_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            envio();
        }

        private void dataGridView_product_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                envio();
            }
        }
    }
}
