
namespace appventas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_User = new System.Windows.Forms.TextBox();
            this.Txt_pass = new System.Windows.Forms.TextBox();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_User
            // 
            this.Txt_User.Location = new System.Drawing.Point(67, 75);
            this.Txt_User.Name = "Txt_User";
            this.Txt_User.Size = new System.Drawing.Size(237, 20);
            this.Txt_User.TabIndex = 0;
            // 
            // Txt_pass
            // 
            this.Txt_pass.Location = new System.Drawing.Point(67, 166);
            this.Txt_pass.Name = "Txt_pass";
            this.Txt_pass.Size = new System.Drawing.Size(237, 20);
            this.Txt_pass.TabIndex = 1;
            this.Txt_pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.Location = new System.Drawing.Point(148, 247);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(95, 43);
            this.Btn_ingresar.TabIndex = 2;
            this.Btn_ingresar.Text = "Entrar";
            this.Btn_ingresar.UseVisualStyleBackColor = true;
            this.Btn_ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese la contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 389);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Txt_pass);
            this.Controls.Add(this.Txt_User);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_User;
        private System.Windows.Forms.TextBox Txt_pass;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

