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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.LabelIngredientes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCrearPlatoDeComida = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(139, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(146, 329);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(432, 59);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(156, 329);
            this.listBox2.TabIndex = 1;
            // 
            // LabelIngredientes
            // 
            this.LabelIngredientes.AutoSize = true;
            this.LabelIngredientes.Location = new System.Drawing.Point(136, 43);
            this.LabelIngredientes.Name = "LabelIngredientes";
            this.LabelIngredientes.Size = new System.Drawing.Size(65, 13);
            this.LabelIngredientes.TabIndex = 2;
            this.LabelIngredientes.Text = "Ingredientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Platos de Comida";
            // 
            // buttonCrearPlatoDeComida
            // 
            this.buttonCrearPlatoDeComida.Location = new System.Drawing.Point(139, 394);
            this.buttonCrearPlatoDeComida.Name = "buttonCrearPlatoDeComida";
            this.buttonCrearPlatoDeComida.Size = new System.Drawing.Size(75, 23);
            this.buttonCrearPlatoDeComida.TabIndex = 4;
            this.buttonCrearPlatoDeComida.Text = "Crear";
            this.buttonCrearPlatoDeComida.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "--------------->";
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(432, 394);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 8;
            this.buttonModificar.Text = "Editar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(513, 395);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 9;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
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
            // FormCocinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 472);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonCrearPlatoDeComida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelIngredientes);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "FormCocinero";
            this.Text = "FormCocinero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label LabelIngredientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCrearPlatoDeComida;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAtras;
    }
}