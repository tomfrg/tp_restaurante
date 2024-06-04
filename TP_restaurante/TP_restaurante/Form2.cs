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

namespace TP_restaurante
{
    public partial class Form2 : Form
    {
        private Empleado usuario;
        public Form2(Empleado _usuario)
        {
            InitializeComponent();
            usuario = _usuario;
            Saludar();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void Saludar()
        {
            lblSaludo.Text = $"Bienvenido {usuario.GetterNombre} {usuario.GetterApellido}";
        }
    }
}
