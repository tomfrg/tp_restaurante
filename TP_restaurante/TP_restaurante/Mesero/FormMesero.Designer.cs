namespace TP_restaurante.Mesero
{
    partial class FormMesero
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
            this.labelSaludo = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonServir = new System.Windows.Forms.Button();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSaludo
            // 
            this.labelSaludo.AutoSize = true;
            this.labelSaludo.Location = new System.Drawing.Point(38, 30);
            this.labelSaludo.Name = "labelSaludo";
            this.labelSaludo.Size = new System.Drawing.Size(61, 13);
            this.labelSaludo.TabIndex = 0;
            this.labelSaludo.Text = "biemvenido";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 277);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de platos de comida";
            // 
            // buttonServir
            // 
            this.buttonServir.Location = new System.Drawing.Point(215, 111);
            this.buttonServir.Name = "buttonServir";
            this.buttonServir.Size = new System.Drawing.Size(75, 23);
            this.buttonServir.TabIndex = 3;
            this.buttonServir.Text = "Servir";
            this.buttonServir.UseVisualStyleBackColor = true;
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(13, 508);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 4;
            this.buttonAtras.Text = "Atras";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // FormMesero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 543);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.buttonServir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelSaludo);
            this.Name = "FormMesero";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormMesero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSaludo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonServir;
        private System.Windows.Forms.Button buttonAtras;
    }
}