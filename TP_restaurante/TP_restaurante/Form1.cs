using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_restaurante.Clases_restaurante;
using TP_restaurante.Cocinero;
using TP_restaurante.Encargado;
using TP_restaurante.Mesero;

namespace TP_restaurante
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void AgregarUsuarioAlListBox(Empleado usuario)
        {
            listBoxUsuarios.Items.Add(usuario);
        }

        private static void MostrarForm(Form form)
        {
            form.Show();
        }

        private bool VerificadorDeTextBox(string i)
            {
                if (string.IsNullOrEmpty(i) || string.IsNullOrWhiteSpace(i))
                {
                    return true;
                }
                return false;
            }

        private void MensajeError(bool nombre, bool apellido)
            {
            if (!nombre && apellido)
            {
                MessageBox.Show("Se deben completar los siguientes campos: \nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nombre && !apellido)
            {
                MessageBox.Show("Se deben completar los siguientes campos: \nNombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nombre && apellido)
            {
                MessageBox.Show("Se deben completar los siguientes campos: \nNombre \nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            listBoxUsuarios.Items.Remove(listBoxUsuarios.SelectedItem);
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxUsuarios.SelectedItem;

            if (selectedItem is Empleado usuarioSeleccionado)
            {
                Form formUsuario;
                switch (usuarioSeleccionado._rol)
                {
                    case RolesEmpleados.Cocinero:
                        formUsuario = new FormCocinero(usuarioSeleccionado);
                        break;
                    case RolesEmpleados.Mesero:
                        formUsuario = new FormMesero();
                        break;
                    case RolesEmpleados.Encargado:
                        formUsuario = new FormEncargado(usuarioSeleccionado);
                        break;
                    default:
                        formUsuario = new FormDelivery(usuarioSeleccionado);
                        break;
                }
                MostrarForm(formUsuario);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario válido de la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAgregarUsuario_Click(object sender, EventArgs e)
        {
            FormAgregarUsuario formAgregarUsuario = new FormAgregarUsuario(this);
            formAgregarUsuario.Show();
        }
    }
}
