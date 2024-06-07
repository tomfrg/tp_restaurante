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
using TP_restaurante.Encargado;

namespace TP_restaurante
{
    public partial class FormEncargado : Form
    {
        private Empleado _usuario;

        private Empleado Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public FormEncargado(Empleado usuario)
        {
            InitializeComponent();
            Usuario = usuario;
            Saludar();
        }
        public FormEncargado()
        {
            InitializeComponent();
        }

        private void FormEncargado_Load(object sender, EventArgs e)
        {

        }

        public void Saludar()
        {
            labelUsuario.Text = $"Bienvenido {Usuario._nombre} {Usuario._apellido}";
        }

        private void buttonCargaProducto_Click(object sender, EventArgs e)
        {
            FormAgregarProducto formAgregarProducto = new FormAgregarProducto(this, Usuario);
            formAgregarProducto.Show();
        }
        public void AgregarProductoAlListBox(Producto producto)
        {
            listBoxProductos.Items.Add(producto);
        }
        public void AgregarProductoALista(Producto producto)
        {
            Almacen.AlmacenarProducto(producto);    
        }

        private void listBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEliminarProducto_Click(object sender, EventArgs e)
        {
            listBoxProductos.Items.Remove(listBoxProductos.SelectedItem);
        }

        private void buttonModificarProducto_Click(object sender, EventArgs e)
        {
            if (listBoxProductos.SelectedItem != null)
            {
                int indiceSeleccionado = listBoxProductos.SelectedIndex;
                string nuevoValor = "Nuevo valor";

                // Modificar el valor en la colección de elementos del ListBox
                listBoxProductos.Items[indiceSeleccionado] = nuevoValor;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}