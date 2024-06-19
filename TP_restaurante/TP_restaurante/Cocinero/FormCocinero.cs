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
        private List<Dictionary<Producto, int>> listProductosSeleccionados = new List<Dictionary<Producto, int>>();
        private bool flagCaracteristicas = true; 
        public FormCocinero(Empleado _usuario)
        {
            InitializeComponent();
            this._usuario = _usuario;

            CargarProductoEnComboBox();
            CargarPlatosDeComidaEnListBox();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            if (comboBoxProducto.SelectedItem != null)
            {
                string nombreProducto = comboBoxProducto.SelectedItem.ToString();

                // Encontrar el objeto Producto correspondiente en la lista de productos
                Producto productoElegido = Restaurante.listaDeProductos.Find(p => p.Nombre == nombreProducto);

                if (productoElegido != null)
                {
                    string cantProductoElegido = textBoxCantidadProducto.Text;

                    if (int.TryParse(cantProductoElegido, out int cantProductoElegidoINT))
                    {
                        if(productoElegido.UsarStock(cantProductoElegidoINT))
                        {
                            listBoxIngredientes.Items.Add($"{cantProductoElegidoINT} - {productoElegido.Nombre}");
                            productosSeleccionados.Add(productoElegido, cantProductoElegidoINT);
                            listProductosSeleccionados.Add(productosSeleccionados);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La cantidad ingresada no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCrearPlatoDeComida_Click(object sender, EventArgs e)
        {
            if (productosSeleccionados.Count > 0)
            { 
                string nombrePlatoDeComida = textBoxNombrePlatoDeComida.Text;
                string tiempoDePreparacionSTRING = textBoxTiempoDePreparacion.Text;

                if (double.TryParse(tiempoDePreparacionSTRING, out double tiempoDePreparacionMIN))
                {
                    TimeSpan tiempoDePreparacion = TimeSpan.FromMinutes(tiempoDePreparacionMIN);

                    // Crear el plato de comida usando la clase estática Cocina
                    PlatoDeComida platoDeComida = new PlatoDeComida(nombrePlatoDeComida, listProductosSeleccionados, tiempoDePreparacion);

                    // Limpiar selección de ingredientes y recargar la lista de platos
                    productosSeleccionados.Clear();
                    listBoxIngredientes.Items.Clear();
                    Restaurante.AgregarPlato(platoDeComida);
                    CargarPlatosDeComidaEnListBox();
                }
                else
                {
                    MessageBox.Show("El tiempo de preparación ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay ingredientes ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       

        public void CargarPlatosDeComidaEnListBox()
        {
            listBoxPlatosDeComida.Items.Clear();

            foreach (var platos in Restaurante.ListaPlatos)
            {
                listBoxPlatosDeComida.Items.Add(platos.Nombre);
            }
        }
        public void CargarProductoEnComboBox()
        {
            comboBoxProducto.Items.Clear();

            foreach (var producto in Almacen.listaDeProductos)
            {
                comboBoxProducto.Items.Add(producto.Nombre);
            }
        }
        private void buttonEliminarProducto_Click(object sender, EventArgs e)
        {
            listBoxIngredientes.Items.Remove(listBoxIngredientes.SelectedItem);
        }
        private void buttonEliminarPlatoDeComida_Click(object sender, EventArgs e)
        {
            PlatoDeComida platoDeComidaSeleccionado = listBoxPlatosDeComida.SelectedItem as PlatoDeComida;

            if (platoDeComidaSeleccionado != null)
            {
                listBoxPlatosDeComida.Items.Remove(listBoxPlatosDeComida.SelectedItem);
                Restaurante.EliminarPlatoDeComida(platoDeComidaSeleccionado);
            }
        }
        private void buttonVerCaracteristicas_Click(object sender, EventArgs e)
        {
            if (listBoxPlatosDeComida.SelectedItem != null)
            {
                int contadorIngredientes = 2;
                string platoSeleccionado = listBoxPlatosDeComida.SelectedItem.ToString();
                PlatoDeComida platoDeComidaSeleccionado = Restaurante.ListaPlatos.Find(p => p.Nombre == platoSeleccionado);

                if (platoDeComidaSeleccionado != null)
                {
                    listBoxPlatosDeComida.Items.Insert(listBoxPlatosDeComida.SelectedIndex + 1, $"  -Time: {platoDeComidaSeleccionado.TiempoDePreparacion}");
                    foreach(var i in platoDeComidaSeleccionado.Ingredientes)
                    {
                        listBoxPlatosDeComida.Items.Insert(listBoxPlatosDeComida.SelectedIndex + contadorIngredientes, platoDeComidaSeleccionado.ObtenerIngredientes());
                        contadorIngredientes = contadorIngredientes + 1;
                    }

                    flagCaracteristicas = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un plato de comida válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flagCaracteristicas = true;
            }
        }

        #region Métodos privados
        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCantidadProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCocinero_Load(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTiempoDePreparacion_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
