namespace TP_restaurante
{
    partial class FormAgregarUsuario
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
            this.buttonCargaDeUsuario = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPuestoDeTrabajo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCargaDeUsuario
            // 
            this.buttonCargaDeUsuario.Location = new System.Drawing.Point(12, 236);
            this.buttonCargaDeUsuario.Name = "buttonCargaDeUsuario";
            this.buttonCargaDeUsuario.Size = new System.Drawing.Size(139, 23);
            this.buttonCargaDeUsuario.TabIndex = 25;
            this.buttonCargaDeUsuario.Text = "Agregar";
            this.buttonCargaDeUsuario.UseVisualStyleBackColor = true;
            this.buttonCargaDeUsuario.Click += new System.EventHandler(this.buttonCargaDeUsuario_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Carga de usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Puesto de trabajo";
            // 
            // comboBoxPuestoDeTrabajo
            // 
            this.comboBoxPuestoDeTrabajo.FormattingEnabled = true;
            this.comboBoxPuestoDeTrabajo.Items.AddRange(new object[] {
            "Mesero",
            "Cocinero",
            "Delivery",
            "Encargado"});
            this.comboBoxPuestoDeTrabajo.Location = new System.Drawing.Point(12, 190);
            this.comboBoxPuestoDeTrabajo.Name = "comboBoxPuestoDeTrabajo";
            this.comboBoxPuestoDeTrabajo.Size = new System.Drawing.Size(147, 21);
            this.comboBoxPuestoDeTrabajo.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "DNI";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(120, 134);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNI.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Dirección";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(120, 81);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDireccion.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(12, 134);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellido.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(12, 81);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 14;
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(12, 308);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 26;
            this.buttonAtras.Text = "Atras";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // FormAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 343);
            this.Controls.Add(this.buttonAtras);
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
            this.Name = "FormAgregarUsuario";
            this.Text = "FormAgregarUsuario";
            this.Load += new System.EventHandler(this.FormAgregarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCargaDeUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPuestoDeTrabajo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonAtras;
    }
}