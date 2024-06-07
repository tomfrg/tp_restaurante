namespace TP_restaurante
{
    partial class FormEncargado
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.listBoxProductos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCargaProducto = new System.Windows.Forms.Button();
            this.buttonEliminarProducto = new System.Windows.Forms.Button();
            this.buttonStockAgotado = new System.Windows.Forms.Button();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(23, 19);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(35, 13);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "label1";
            // 
            // listBoxProductos
            // 
            this.listBoxProductos.FormattingEnabled = true;
            this.listBoxProductos.Location = new System.Drawing.Point(29, 99);
            this.listBoxProductos.Name = "listBoxProductos";
            this.listBoxProductos.Size = new System.Drawing.Size(161, 277);
            this.listBoxProductos.TabIndex = 1;
            this.listBoxProductos.SelectedIndexChanged += new System.EventHandler(this.listBoxProductos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de productos";
            // 
            // buttonCargaProducto
            // 
            this.buttonCargaProducto.Location = new System.Drawing.Point(196, 99);
            this.buttonCargaProducto.Name = "buttonCargaProducto";
            this.buttonCargaProducto.Size = new System.Drawing.Size(101, 23);
            this.buttonCargaProducto.TabIndex = 3;
            this.buttonCargaProducto.Text = "Cargar Producto";
            this.buttonCargaProducto.UseVisualStyleBackColor = true;
            this.buttonCargaProducto.Click += new System.EventHandler(this.buttonCargaProducto_Click);
            // 
            // buttonEliminarProducto
            // 
            this.buttonEliminarProducto.Location = new System.Drawing.Point(196, 145);
            this.buttonEliminarProducto.Name = "buttonEliminarProducto";
            this.buttonEliminarProducto.Size = new System.Drawing.Size(101, 23);
            this.buttonEliminarProducto.TabIndex = 5;
            this.buttonEliminarProducto.Text = "Eliminar";
            this.buttonEliminarProducto.UseVisualStyleBackColor = true;
            this.buttonEliminarProducto.Click += new System.EventHandler(this.buttonEliminarProducto_Click);
            // 
            // buttonStockAgotado
            // 
            this.buttonStockAgotado.Location = new System.Drawing.Point(29, 382);
            this.buttonStockAgotado.Name = "buttonStockAgotado";
            this.buttonStockAgotado.Size = new System.Drawing.Size(101, 40);
            this.buttonStockAgotado.TabIndex = 6;
            this.buttonStockAgotado.Text = "Stock por agotarse";
            this.buttonStockAgotado.UseVisualStyleBackColor = true;
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(13, 461);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 7;
            this.buttonAtras.Text = "Atras";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // FormEncargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 496);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.buttonStockAgotado);
            this.Controls.Add(this.buttonEliminarProducto);
            this.Controls.Add(this.buttonCargaProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxProductos);
            this.Controls.Add(this.labelUsuario);
            this.Name = "FormEncargado";
            this.Text = "FormEncargado";
            this.Load += new System.EventHandler(this.FormEncargado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.ListBox listBoxProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCargaProducto;
        private System.Windows.Forms.Button buttonEliminarProducto;
        private System.Windows.Forms.Button buttonStockAgotado;
        private System.Windows.Forms.Button buttonAtras;
    }
}