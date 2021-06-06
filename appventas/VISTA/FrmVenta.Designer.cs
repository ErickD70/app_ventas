
namespace appventas.VISTA
{
    partial class FrmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_ultimaventa = new System.Windows.Forms.TextBox();
            this.txt_precioprod = new System.Windows.Forms.TextBox();
            this.txt_b_Producto = new System.Windows.Forms.TextBox();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Txt_nameProduct = new System.Windows.Forms.TextBox();
            this.cbx_tipo_documento = new System.Windows.Forms.ComboBox();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_total_fin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_ultimaventa
            // 
            this.Txt_ultimaventa.Enabled = false;
            this.Txt_ultimaventa.Location = new System.Drawing.Point(170, 69);
            this.Txt_ultimaventa.Name = "Txt_ultimaventa";
            this.Txt_ultimaventa.Size = new System.Drawing.Size(226, 20);
            this.Txt_ultimaventa.TabIndex = 0;
            this.Txt_ultimaventa.TextChanged += new System.EventHandler(this.Txt_Documento_TextChanged);
            // 
            // txt_precioprod
            // 
            this.txt_precioprod.Enabled = false;
            this.txt_precioprod.Location = new System.Drawing.Point(505, 274);
            this.txt_precioprod.Name = "txt_precioprod";
            this.txt_precioprod.Size = new System.Drawing.Size(199, 20);
            this.txt_precioprod.TabIndex = 1;
            // 
            // txt_b_Producto
            // 
            this.txt_b_Producto.Location = new System.Drawing.Point(170, 172);
            this.txt_b_Producto.Name = "txt_b_Producto";
            this.txt_b_Producto.Size = new System.Drawing.Size(286, 20);
            this.txt_b_Producto.TabIndex = 2;
            this.txt_b_Producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Buscar_Producto_KeyPress);
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(722, 274);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(110, 20);
            this.txtcant.TabIndex = 3;
            this.txtcant.TextChanged += new System.EventHandler(this.txtcant_TextChanged);
            this.txtcant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcant_KeyPress);
            // 
            // Txt_Id
            // 
            this.Txt_Id.Enabled = false;
            this.Txt_Id.Location = new System.Drawing.Point(39, 274);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(222, 20);
            this.Txt_Id.TabIndex = 4;
            this.Txt_Id.TextChanged += new System.EventHandler(this.Txt_Id_TextChanged);
            // 
            // Txt_nameProduct
            // 
            this.Txt_nameProduct.Enabled = false;
            this.Txt_nameProduct.Location = new System.Drawing.Point(278, 274);
            this.Txt_nameProduct.Name = "Txt_nameProduct";
            this.Txt_nameProduct.Size = new System.Drawing.Size(209, 20);
            this.Txt_nameProduct.TabIndex = 5;
            // 
            // cbx_tipo_documento
            // 
            this.cbx_tipo_documento.FormattingEnabled = true;
            this.cbx_tipo_documento.Location = new System.Drawing.Point(652, 72);
            this.cbx_tipo_documento.Name = "cbx_tipo_documento";
            this.cbx_tipo_documento.Size = new System.Drawing.Size(193, 21);
            this.cbx_tipo_documento.TabIndex = 6;
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Items.AddRange(new object[] {
            "ID"});
            this.cbxCliente.Location = new System.Drawing.Point(652, 118);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(193, 21);
            this.cbxCliente.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Num. Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo de documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Codigo del Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nombre del Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Precio del Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(719, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cantidad";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(475, 165);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 32);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(41, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 196);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(422, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Formulario de ventas";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(858, 274);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(94, 20);
            this.txt_total.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(855, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Total";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(855, 337);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(97, 41);
            this.btn_guardar.TabIndex = 21;
            this.btn_guardar.Text = "button1";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_total_fin
            // 
            this.txt_total_fin.Location = new System.Drawing.Point(782, 547);
            this.txt_total_fin.Name = "txt_total_fin";
            this.txt_total_fin.Size = new System.Drawing.Size(170, 20);
            this.txt_total_fin.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(779, 531);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Total final";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 579);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_total_fin);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.cbx_tipo_documento);
            this.Controls.Add(this.Txt_nameProduct);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.txt_b_Producto);
            this.Controls.Add(this.txt_precioprod);
            this.Controls.Add(this.Txt_ultimaventa);
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_ultimaventa;
        private System.Windows.Forms.TextBox txt_b_Producto;
        private System.Windows.Forms.ComboBox cbx_tipo_documento;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.TextBox txt_precioprod;
        public System.Windows.Forms.TextBox Txt_Id;
        public System.Windows.Forms.TextBox Txt_nameProduct;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_total_fin;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtcant;
    }
}