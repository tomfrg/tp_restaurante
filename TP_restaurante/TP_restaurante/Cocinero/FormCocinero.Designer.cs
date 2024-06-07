namespace TP_restaurante.Cocinero
{
    partial class FormCocinero
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
            this.listBoxIngredientes = new System.Windows.Forms.ListBox();
            this.listBoxPlatosDeComida = new System.Windows.Forms.ListBox();
            this.LabelIngredientes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCrearPlatoDeComida = new System.Windows.Forms.Button();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.textBoxNombrePlatoDeComida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEliminarPlatoDeComida = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAgregarProducto = new System.Windows.Forms.Button();
            this.buttonEliminarProducto = new System.Windows.Forms.Button();
            this.textBoxCantidadProducto = new System.Windows.Forms.TextBox();
            this.buttonEditarPlato = new System.Windows.Forms.Button();
            this.buttonVerIngredientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxIngredientes
            // 
            this.listBoxIngredientes.FormattingEnabled = true;
            this.listBoxIngredientes.Location = new System.Drawing.Point(199, 59);
            this.listBoxIngredientes.Name = "listBoxIngredientes";
            this.listBoxIngredientes.Size = new System.Drawing.Size(146, 329);
            this.listBoxIngredientes.TabIndex = 0;
            this.listBoxIngredientes.SelectedIndexChanged += new System.EventHandler(this.listBoxIngredientes_SelectedIndexChanged);
            // 
            // listBoxPlatosDeComida
            // 
            this.listBoxPlatosDeComida.FormattingEnabled = true;
            this.listBoxPlatosDeComida.Location = new System.Drawing.Point(432, 59);
            this.listBoxPlatosDeComida.Name = "listBoxPlatosDeComida";
            this.listBoxPlatosDeComida.Size = new System.Drawing.Size(156, 329);
            this.listBoxPlatosDeComida.TabIndex = 1;
            // 
            // LabelIngredientes
            // 
            this.LabelIngredientes.AutoSize = true;
            this.LabelIngredientes.Location = new System.Drawing.Point(196, 43);
            this.LabelIngredientes.Name = "LabelIngredientes";
            this.LabelIngredientes.Size = new System.Drawing.Size(65, 13);
            this.LabelIngredientes.TabIndex = 2;
            this.LabelIngredientes.Text = "Ingredientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Platos de Comida";
            // 
            // buttonCrearPlatoDeComida
            // 
            this.buttonCrearPlatoDeComida.Location = new System.Drawing.Point(232, 394);
            this.buttonCrearPlatoDeComida.Name = "buttonCrearPlatoDeComida";
            this.buttonCrearPlatoDeComida.Size = new System.Drawing.Size(75, 23);
            this.buttonCrearPlatoDeComida.TabIndex = 4;
            this.buttonCrearPlatoDeComida.Text = "Crear";
            this.buttonCrearPlatoDeComida.UseVisualStyleBackColor = true;
            this.buttonCrearPlatoDeComida.Click += new System.EventHandler(this.buttonCrearPlatoDeComida_Click);
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(72, 123);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProducto.TabIndex = 5;
            this.comboBoxProducto.Text = "Ingrediente";
            this.comboBoxProducto.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducto_SelectedIndexChanged);
            // 
            // textBoxNombrePlatoDeComida
            // 
            this.textBoxNombrePlatoDeComida.Location = new System.Drawing.Point(12, 75);
            this.textBoxNombrePlatoDeComida.Name = "textBoxNombrePlatoDeComida";
            this.textBoxNombrePlatoDeComida.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombrePlatoDeComida.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "--------------->";
            // 
            // buttonEliminarPlatoDeComida
            // 
            this.buttonEliminarPlatoDeComida.Location = new System.Drawing.Point(513, 394);
            this.buttonEliminarPlatoDeComida.Name = "buttonEliminarPlatoDeComida";
            this.buttonEliminarPlatoDeComida.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarPlatoDeComida.TabIndex = 9;
            this.buttonEliminarPlatoDeComida.Text = "Eliminar";
            this.buttonEliminarPlatoDeComida.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cocina para cocinar comida cocinable";
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(13, 437);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 11;
            this.buttonAtras.Text = "Atras";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre de plato de comida";
            // 
            // buttonAgregarProducto
            // 
            this.buttonAgregarProducto.Location = new System.Drawing.Point(12, 150);
            this.buttonAgregarProducto.Name = "buttonAgregarProducto";
            this.buttonAgregarProducto.Size = new System.Drawing.Size(53, 23);
            this.buttonAgregarProducto.TabIndex = 14;
            this.buttonAgregarProducto.Text = "Agregar";
            this.buttonAgregarProducto.UseVisualStyleBackColor = true;
            this.buttonAgregarProducto.Click += new System.EventHandler(this.buttonAgregarProducto_Click);
            // 
            // buttonEliminarProducto
            // 
            this.buttonEliminarProducto.Location = new System.Drawing.Point(13, 179);
            this.buttonEliminarProducto.Name = "buttonEliminarProducto";
            this.buttonEliminarProducto.Size = new System.Drawing.Size(52, 23);
            this.buttonEliminarProducto.TabIndex = 15;
            this.buttonEliminarProducto.Text = "Eliminar";
            this.buttonEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // textBoxCantidadProducto
            // 
            this.textBoxCantidadProducto.Location = new System.Drawing.Point(12, 124);
            this.textBoxCantidadProducto.Name = "textBoxCantidadProducto";
            this.textBoxCantidadProducto.Size = new System.Drawing.Size(53, 20);
            this.textBoxCantidadProducto.TabIndex = 16;
            this.textBoxCantidadProducto.Text = "Cantidad";
            this.textBoxCantidadProducto.TextChanged += new System.EventHandler(this.textBoxCantidadProducto_TextChanged);
            // 
            // buttonEditarPlato
            // 
            this.buttonEditarPlato.Location = new System.Drawing.Point(432, 394);
            this.buttonEditarPlato.Name = "buttonEditarPlato";
            this.buttonEditarPlato.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarPlato.TabIndex = 17;
            this.buttonEditarPlato.Text = "Editar";
            this.buttonEditarPlato.UseVisualStyleBackColor = true;
            // 
            // buttonVerIngredientes
            // 
            this.buttonVerIngredientes.Location = new System.Drawing.Point(432, 424);
            this.buttonVerIngredientes.Name = "buttonVerIngredientes";
            this.buttonVerIngredientes.Size = new System.Drawing.Size(156, 23);
            this.buttonVerIngredientes.TabIndex = 18;
            this.buttonVerIngredientes.Text = "Ver Ingredietnes";
            this.buttonVerIngredientes.UseVisualStyleBackColor = true;
            // 
            // FormCocinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 472);
            this.Controls.Add(this.buttonVerIngredientes);
            this.Controls.Add(this.buttonEditarPlato);
            this.Controls.Add(this.textBoxCantidadProducto);
            this.Controls.Add(this.buttonEliminarProducto);
            this.Controls.Add(this.buttonAgregarProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonEliminarPlatoDeComida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombrePlatoDeComida);
            this.Controls.Add(this.comboBoxProducto);
            this.Controls.Add(this.buttonCrearPlatoDeComida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelIngredientes);
            this.Controls.Add(this.listBoxPlatosDeComida);
            this.Controls.Add(this.listBoxIngredientes);
            this.Name = "FormCocinero";
            this.Text = "FormCocinero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxIngredientes;
        private System.Windows.Forms.ListBox listBoxPlatosDeComida;
        private System.Windows.Forms.Label LabelIngredientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCrearPlatoDeComida;
        private System.Windows.Forms.ComboBox comboBoxProducto;
        private System.Windows.Forms.TextBox textBoxNombrePlatoDeComida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEliminarPlatoDeComida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAgregarProducto;
        private System.Windows.Forms.Button buttonEliminarProducto;
        private System.Windows.Forms.TextBox textBoxCantidadProducto;
        private System.Windows.Forms.Button buttonEditarPlato;
        private System.Windows.Forms.Button buttonVerIngredientes;
    }
}