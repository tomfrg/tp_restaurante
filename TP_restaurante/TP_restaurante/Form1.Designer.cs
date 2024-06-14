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
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxUsuarios = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonAgregarUsuario = new System.Windows.Forms.Button();
            this.buttonHardcorear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Usuarios";
            // 
            // listBoxUsuarios
            // 
            this.listBoxUsuarios.FormattingEnabled = true;
            this.listBoxUsuarios.Location = new System.Drawing.Point(15, 132);
            this.listBoxUsuarios.Name = "listBoxUsuarios";
            this.listBoxUsuarios.Size = new System.Drawing.Size(213, 238);
            this.listBoxUsuarios.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lista de usuarios";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(234, 173);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(139, 23);
            this.buttonEliminar.TabIndex = 16;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(234, 132);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(139, 23);
            this.buttonIngresar.TabIndex = 17;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonAgregarUsuario
            // 
            this.buttonAgregarUsuario.Location = new System.Drawing.Point(234, 309);
            this.buttonAgregarUsuario.Name = "buttonAgregarUsuario";
            this.buttonAgregarUsuario.Size = new System.Drawing.Size(75, 61);
            this.buttonAgregarUsuario.TabIndex = 18;
            this.buttonAgregarUsuario.Text = "Agregar Usuario";
            this.buttonAgregarUsuario.UseVisualStyleBackColor = true;
            this.buttonAgregarUsuario.Click += new System.EventHandler(this.buttonAgregarUsuario_Click);
            // 
            // buttonHardcorear
            // 
            this.buttonHardcorear.Location = new System.Drawing.Point(110, 416);
            this.buttonHardcorear.Name = "buttonHardcorear";
            this.buttonHardcorear.Size = new System.Drawing.Size(75, 23);
            this.buttonHardcorear.TabIndex = 19;
            this.buttonHardcorear.Text = "Hardcorear";
            this.buttonHardcorear.UseVisualStyleBackColor = true;
            this.buttonHardcorear.Click += new System.EventHandler(this.buttonHardcorear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 451);
            this.Controls.Add(this.buttonHardcorear);
            this.Controls.Add(this.buttonAgregarUsuario);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxUsuarios);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxUsuarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonAgregarUsuario;
        private System.Windows.Forms.Button buttonHardcorear;
    }
}

