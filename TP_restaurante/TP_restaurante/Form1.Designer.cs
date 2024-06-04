namespace TP_restaurante
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.comboBoxPuestoDeTrabajo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCargaDeUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(41, 84);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(41, 137);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellido.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dirección";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(170, 84);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDireccion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "DNI";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(170, 137);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNI.TabIndex = 8;
            // 
            // comboBoxPuestoDeTrabajo
            // 
            this.comboBoxPuestoDeTrabajo.FormattingEnabled = true;
            this.comboBoxPuestoDeTrabajo.Items.AddRange(new object[] {
            "Mesero",
            "Cocinero",
            "Delivey",
            "Encargado"});
            this.comboBoxPuestoDeTrabajo.Location = new System.Drawing.Point(41, 205);
            this.comboBoxPuestoDeTrabajo.Name = "comboBoxPuestoDeTrabajo";
            this.comboBoxPuestoDeTrabajo.Size = new System.Drawing.Size(147, 21);
            this.comboBoxPuestoDeTrabajo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Puesto de trabajo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Carga de usuario";
            // 
            // buttonCargaDeUsuario
            // 
            this.buttonCargaDeUsuario.Location = new System.Drawing.Point(91, 325);
            this.buttonCargaDeUsuario.Name = "buttonCargaDeUsuario";
            this.buttonCargaDeUsuario.Size = new System.Drawing.Size(139, 23);
            this.buttonCargaDeUsuario.TabIndex = 13;
            this.buttonCargaDeUsuario.Text = "Lesto";
            this.buttonCargaDeUsuario.UseVisualStyleBackColor = true;
            this.buttonCargaDeUsuario.Click += new System.EventHandler(this.buttonCargaDeUsuario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 375);
            this.Controls.Add(this.buttonCargaDeUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxPuestoDeTrabajo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.ComboBox comboBoxPuestoDeTrabajo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCargaDeUsuario;
    }
}

