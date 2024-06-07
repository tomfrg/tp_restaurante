using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_restaurante.Clases_restaurante;
using System.Text.Json;
using System.IO;

namespace TP_restaurante.Encargado
{
    public partial class FormAgregarProducto : Form
    {
        private FormEncargado _formEncargado;
        private Empleado _usuario;

        public FormAgregarProducto(FormEncargado formEncargado, Empleado usuario)
        {
            InitializeComponent();
            _formEncargado = formEncargado;
            _usuario = usuario;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormAgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productoNombre = comboBoxProducto.Text; 
            string cantidadProducto = textBoxCantidadProducto.Text;

            if (int.TryParse(cantidadProducto, out int cantidadProductoInt))
            {
                Producto producto = new Producto(productoNombre, cantidadProductoInt, 1);

                _formEncargado.AgregarProductoAlListBox(producto);

                this.Hide();
            }
            else
            {
                // Muestra un mensaje de error si la cantidad no es un número válido
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            FormEncargado formEncargado = new FormEncargado();
            formEncargado.Show();
            this.Hide();
        }
    }
}
