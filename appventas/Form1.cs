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

namespace appventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cls_Acceso acce = new Cls_Acceso();

            int valor = acce.acceso(Txt_User.Text,Txt_pass.Text);

            if (valor==1)
            {
                MessageBox.Show("Welcome");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
