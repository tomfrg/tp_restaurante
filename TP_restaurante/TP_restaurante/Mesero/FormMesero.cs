using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_restaurante.Mesero
{
    public partial class FormMesero : Form
    {
        public FormMesero()
        {
            InitializeComponent();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void FormMesero_Load(object sender, EventArgs e)
        {

        }
    }
}
