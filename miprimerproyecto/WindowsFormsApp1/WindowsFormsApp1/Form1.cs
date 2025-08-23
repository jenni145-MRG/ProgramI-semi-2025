using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class cbxItems : Form
    {
        public cbxItems()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(txtCantidad.Text);
            double respuesta;
            txtCantidad.Text = Convert.ToString(monto);
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    respuesta = monto * 1.17;
                    lblResultado.Text = "Resultado :" + respuesta.ToString();
                    break;
                case 2:
                    respuesta = monto * 0.0068;
                    lblResultado.Text = "Resultado :" + respuesta.ToString();
                    break;
                case 3:
                    respuesta = monto * 1.36;
                    lblResultado.Text = "Resultado :" + respuesta.ToString();
                    break;
                case 4:
                    respuesta = monto * 0.72;
                    lblResultado.Text = "Resultado" + respuesta.ToString();
                    break;
                case 5:
                    respuesta = monto * 0.65;
                    lblResultado.Text = "Resultado :" + respuesta.ToString();
                    break;
                case 6:
                    respuesta = monto * 1.24;
                    lblResultado.Text = "Resultado :" + respuesta.ToString();
                    break;
                case 7:
                    respuesta = monto * 0.14;
                    lblResultado.Text = "Resultado :" + respuesta.ToString();
                    break;
                case 8:
                    respuesta = monto * 0.78;
                    lblResultado.Text = "Resultado :" + respuesta.ToString();
                    break;
                case 9:
                    respuesta = monto * 0.0053;
                    lblResultado.Text = "Resultado :" + respuesta.ToString();
                    break;
                case 10:
                    respuesta = monto * 0.19;
                    lblResultado.Text = "Resultado :" + respuesta.ToString();
                    break;

            }
            switch (cbxMasa.SelectedIndex)
            {
                case 1:
                    respuesta = monto * 2.20462;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();
                    break;

                case 2:
                    respuesta = monto * 0.035274;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();
                    break;

                case 3:
                    respuesta = monto * 0.001;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 4:
                    respuesta = monto * 2204.62;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 5:
                    respuesta = monto * 0.453592;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 6:
                    respuesta = monto * 28.3495;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 7:
                    respuesta = monto * 0.2;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 8:
                    respuesta = monto * 6.35029;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 9:
                    respuesta = monto * 0.001;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 10:
                    respuesta = monto * 14.5939;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
            }
            switch (cbxVolumen.SelectedIndex)
            {
                case 1:
                    respuesta = monto * 1000;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();
                    break;

                case 2:
                    respuesta = monto * 3.785;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();
                    break;

                case 3:
                    respuesta = monto * 1000;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 4:
                    respuesta = monto * 295735;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 5:
                    respuesta = monto * 158.987;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 6:
                    respuesta = monto * 0.473;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 7:
                    respuesta = monto * 236.588;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 8:
                    respuesta = monto * 100;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 9:
                    respuesta = 1000 * monto;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 10:
                    respuesta = monto * 0.0283
                    ;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;

            }
            switch (cbxLongitud.SelectedIndex)
            {
                case 1:
                    respuesta = monto * 0.62137;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();
                    break;

                case 2:
                    respuesta = monto * 0.3048;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();
                    break;

                case 3:
                    respuesta = monto * 2.54;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 4:
                    respuesta = monto * 0.9144;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 5:
                    respuesta = monto * 1.852;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 6:
                    respuesta = monto * 10;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 7:
                    respuesta = monto * 100;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 8:
                    respuesta = monto / 1000 * 1;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 9:
                    respuesta = monto * 0.001;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 10:
                    respuesta = monto * 14.5939;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;

            }
            switch (cbxAlmacenamiento.SelectedIndex)
            {
                case 1:
                    respuesta = monto * 2.20462;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();
                    break;

                case 2:
                    respuesta = monto * 0.035274;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();
                    break;

                case 3:
                    respuesta = monto * 0.001;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 4:
                    respuesta = monto * 2204.62;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 5:
                    respuesta = monto * 0.453592;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 6:
                    respuesta = monto * 28.3495;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 7:
                    respuesta = monto * 0.2;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 8:
                    respuesta = monto * 6.35029;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 9:
                    respuesta = monto * 0.001;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 10:
                    respuesta = monto * 14.5939;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
            }
            switch (cbxTiempo.SelectedIndex)
            {
                case 1:
                    respuesta = monto * 2.20462;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();
                    break;

                case 2:
                    respuesta = monto * 0.035274;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();
                    break;

                case 3:
                    respuesta = monto * 0.001;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 4:
                    respuesta = monto * 2204.62;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 5:
                    respuesta = monto * 0.453592;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 6:
                    respuesta = monto * 28.3495;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 7:
                    respuesta = monto * 0.2;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 8:
                    respuesta = monto * 6.35029;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 9:
                    respuesta = monto * 0.001;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
                case 10:
                    respuesta = monto * 14.5939;
                    lblResultado.Text = "Resultado: " + respuesta.ToString();

                    break;
            }
        }
                        
                   

        private void cbxItems_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}




