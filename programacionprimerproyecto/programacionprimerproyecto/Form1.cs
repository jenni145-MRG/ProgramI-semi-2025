using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacionprimerproyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSaludo_Click(object sender, EventArgs e)
        {

        }

        private void btnsaludar_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = "¡Hola " + txtNombre.Text + "!";
        }
    }
}
