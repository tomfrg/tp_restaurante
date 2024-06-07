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

namespace TP_restaurante.Cocinero
{
    public partial class FormCocinero : Form
    {
        private Empleado _usuario;
        private Dictionary<Producto, int> productosSeleccionados = new Dictionary<Producto, int>();

        public FormCocinero(Empleado _usuario)
        {
            InitializeComponent();
            this._usuario = _usuario;

            foreach (var item in Almacen.listaDeProductos)
            {
                comboBoxProducto.Items.Add(item.Nombre);
            }
            comboBoxProducto.DisplayMember = "Nombre";
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            if (comboBoxProducto.SelectedItem is Producto ingredienteSeleccionado)
            {
                if (int.TryParse(textBoxCantidadProducto.Text, out int cantidad) && cantidad > 0)
                {
                    if (productosSeleccionados.ContainsKey(ingredienteSeleccionado))
                    {
                        productosSeleccionados[ingredienteSeleccionado] += cantidad;
                    }
                    else
                    {
                        productosSeleccionados.Add(ingredienteSeleccionado, cantidad);
                    }

                    MessageBox.Show($"Producto agregado: {ingredienteSeleccionado.Nombre}, Cantidad: {cantidad}");
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad válida mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCrearPlatoDeComida_Click(object sender, EventArgs e)
        {
            string nombrePlatoDeComida = textBoxNombrePlatoDeComida.Text;

            if (!string.IsNullOrWhiteSpace(nombrePlatoDeComida) && productosSeleccionados.Count > 0)
            {
                DateTime tiempoDePreparacion = DateTime.Now;
                PlatoDeComida platoDeComida = new PlatoDeComida(nombrePlatoDeComida, productosSeleccionados, tiempoDePreparacion);

                listBoxPlatosDeComida.Items.Add(platoDeComida);
            }
            else
            {
                MessageBox.Show("Ingrese un nombre para el plato de comida y agregue al menos un ingrediente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCantidadProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
