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

        private void buttonCargaDeUsuario_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            string direccion = textBoxDireccion.Text;
            string dni = textBoxDNI.Text;
            string rol = comboBoxPuestoDeTrabajo.Text;

            RolesEmpleados rolEnum = (RolesEmpleados)Enum.Parse(typeof(RolesEmpleados), rol);
            int dniInt = int.Parse(dni.ToString());

            if (VerificadorDeTextBox(nombre) || VerificadorDeTextBox(apellido))
            {
                MensajeError(VerificadorDeTextBox(nombre), VerificadorDeTextBox(apellido));
            }
            else
            {
                Empleado usuario = new Empleado(nombre,apellido,direccion, dniInt, rolEnum);
                Form2 form2 = new Form2(usuario);
                this.Hide();
                form2.Show();
            }
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

    }
}
