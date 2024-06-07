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

namespace TP_restaurante.Cocinero
{
    public partial class FormCocinero : Form
    {
        private Empleado _usuario;
        public FormCocinero(Empleado _usuario)
        {
            InitializeComponent();
            this._usuario = _usuario;
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
