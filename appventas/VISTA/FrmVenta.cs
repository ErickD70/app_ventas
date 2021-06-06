using appventas.DAO;
using appventas.MODEL;
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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }
        void Lastventa()
        {
            var consultaultimaventa = new Cls_Venta();

            int lista = 0;

            foreach (var list in consultaultimaventa.UltimaVenta())
            {
                lista = list.iDVenta;
            }

            lista++;
            Txt_ultimaventa.Text = lista.ToString();
        }
       
        private void FrmVenta_Load(object sender, EventArgs e)
            {
            Lastventa();

                Cls_Cliente clscliente = new Cls_Cliente();
                
                cbxCliente.DataSource = clscliente.CargarComboCliente();
                cbxCliente.DisplayMember = "nombre_del_Cliente";
                cbxCliente.ValueMember = "iDCliente";

                Cls_Documento clsdocumento = new Cls_Documento();

                cbx_tipo_documento.DataSource = clsdocumento.CargarComboDocumento();
                cbx_tipo_documento.DisplayMember = "nombre_del_Documento";
                cbx_tipo_documento.ValueMember = "iDDocumento";
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmProducto buscar = new FrmProducto();
            buscar.Show();
            btn_guardar.PerformClick();
        }

        private void Txt_Documento_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcant_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double precio, cantida, total;

                cantida = Convert.ToDouble(txtcant.Text);
                precio = Convert.ToDouble(txt_precioprod.Text);

                total = precio * cantida;

                txt_total.Text = total.ToString();
            }
            catch (Exception ex)
            {
                if (txtcant.Text.Equals(""))
                {
                    txtcant.Text = "0";
                    txtcant.SelectAll();
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            Double suma = 0;
            for (int i= 0; i < dataGridView1.Rows.Count; i++)
            {
                String datosaoperartotal = dataGridView1.Rows[i].Cells[4].Value.ToString();

                Double DatosConvert = Convert.ToDouble(datosaoperartotal);
                

                suma += DatosConvert;

                txt_total_fin.Text = suma.ToString();

                Txt_Id.Text = "";
                Txt_nameProduct.Clear();
                txt_precioprod.Text = "";
                txtcant.Clear();
                txt_total.Text = "";
            }

        }

        private void txt_b_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_b_Producto.Text.Equals(""))
            {

            
                if (e.KeyChar == 13)
                {
                e.Handled = true;
                txtcant.Focus();

                }
            }
            else
            {
                if (e.KeyChar == 13)
                {



                }

            }

    }

    private void txtcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_b_Producto.Focus();

            }
        }
    }
}
