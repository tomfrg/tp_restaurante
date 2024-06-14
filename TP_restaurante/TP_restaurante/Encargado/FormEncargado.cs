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
        private Empleado _empleado;

        public FormEncargado(Empleado empleado)
        {
            InitializeComponent();
            _empleado = empleado;
            CargarProductosEnListBox();
        }
        private void buttonCargaProducto_Click(object sender, EventArgs e)
        {
            FormAgregarProducto formAgregarProducto = new FormAgregarProducto(this, _empleado);
            formAgregarProducto.Show();
        }
        public void AgregarProducto(string productoNombre, int cantidadProductoInt) //agrega producto
        {
            Producto producto = new Producto(productoNombre, cantidadProductoInt, 1);
            if (Almacen.AlmacenarProducto(producto))
            {
                listBoxProductos.Items.Add(producto);
            }
            else
            {
                MessageBox.Show("El producto ya existe en el almacén.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonEliminarProducto_Click(object sender, EventArgs e)
        {
            Producto productoSeleccionado = listBoxProductos.SelectedItem as Producto;

            if (productoSeleccionado != null)
            {
                listBoxProductos.Items.Remove(productoSeleccionado);
                Almacen.EliminarProducto(productoSeleccionado);
            }
        }
        public void CargarProductosEnListBox()
        {
            listBoxProductos.Items.Clear(); // Limpiar el ListBox antes de agregar nuevos productos

            foreach (var producto in Almacen.listaDeProductos)
            {
                listBoxProductos.Items.Add(producto);
            }
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

        #region Métodos privados
        private void listBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FormEncargado_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}