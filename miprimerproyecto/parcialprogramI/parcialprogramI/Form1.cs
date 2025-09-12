using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcialprogramI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] desde = new double[]
{
      0.01, 500.01, 1000.01, 2000.01, 3000.01, 8000.01, 18000.01, 30000.01, 60000.01, 100000.01, 200000.01, 300000.01, 400000.01, 500000.01, 1000000.01
};

        double[] hasta = new double[]
        {
         500, 1000, 2000, 3000, 6000, 18000, 30000, 600000, 100000, 200000, 300000, 400000, 500000, 1000000, 99999999
        };

        double[] precioAd = new double[]
        {
         0, 3, 3, 3, 3, 2, 2, 1, 0.8, 0.6, 0.6, 0.45, 0.4, 0.3, 0.18
        };


        private void form1_load(object sender, EventArgs e)
        {

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtMonto.Text);
            for (int i = 0; i < desde.Length; i++)
            {
                if (monto >= desde[i] && monto <= hasta[i])
                {
                    double total = (monto / hasta[i]) * precioAd[i] + precioAd[i];
                    lblMonto.Text = "El impuesto a pagar es: " + total.ToString("F2");
                }
            }
        }

                


        
        private void lbResultado_Click(object sender, EventArgs e)
        {
            
            
        }

                

        private void txtMonto_TextChanged(double monto )
        {
            

                
            
          
    }

        private void lblMonto_Click(object sender, EventArgs e)
        {

        }
    }
}
