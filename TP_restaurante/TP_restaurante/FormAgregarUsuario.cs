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
using TP_restaurante.Cocinero;
using TP_restaurante.Mesero;

namespace TP_restaurante
{
    public partial class FormAgregarUsuario : Form
    {
        private Form1 _Form1;
        public FormAgregarUsuario(Form1 Form1)
        {
            InitializeComponent();
            _Form1 = Form1;
        }

        private void FormAgregarUsuario_Load(object sender, EventArgs e)
        {

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

        private void MensajeError(bool nombre, bool apeliido)
        {
            if (!(nombre) && apeliido)
            {
                MessageBox.Show($"Se deben completar los siguientes campos: \nApeliido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nombre && !(apeliido))
                {
                    MessageBox.Show($"Se deben completar los siguientes campos: \nNombre ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (nombre && apeliido)
                {
                    MessageBox.Show($"Se deben completar los siguientes campos: \nNombre \nApeliido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonCargaDeUsuario_Click_1(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            string direccion = textBoxDireccion.Text;
            string dni = textBoxDNI.Text;
            string rol = comboBoxPuestoDeTrabajo.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Enum.TryParse(rol, out RolesEmpleados rolEnum))
            {
                MessageBox.Show("El rol seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(dni, out int dniInt))
            {
                MessageBox.Show("El DNI debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Empleado usuario = new Empleado(nombre, apellido, direccion, dniInt, rolEnum);
            _Form1.AgregarUsuarioAlListBox(usuario);
            this.Close();
        }
    }
}
