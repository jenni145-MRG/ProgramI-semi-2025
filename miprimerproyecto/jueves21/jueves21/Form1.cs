using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jueves21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string[][] etiquetas = new string[][]
            {
                new string [] {"Dolar","pesos mexicanos","quetzal","lempira","colon SV"},//monedas
                new string[]{"metros","cm","pulgadas","pie","varas","yardas","metro cuadrado","kilometro cuadrado"},
               new string[]{ "libra", "onza", "gramo", "kg" },
         new string[]{ "galon", "litros", "pinta", "ml" },
          new string[]{ "GB", "bite", "kb", "mb" },
          new string[]{"km2","Mt2","milla cuadrada","yarda cuadrada","pie cuadrado"}
            };
            double[][] valores = new double[][] {
            new double []{1,18.78, 7.66, 26.15, 8.75, 36.78, 504.12}, //Monedas
            new double []{1, 100, 39.37, 3.28084, 1.193, 1.09361, 0.001, 0.000621371,1e-6}, //Longitud
            new double []{1, 16, 453.592, 0.453592, 0.01, 0.001,0.0005}, //Masa
            new double []{1, 3.78541, 8, 3785.41}, //Volumen
            new double []{1, 8e+9, 1e+9, 1e+6, 1000, 0.001}, //Almacenamiento
            new double []{1, 86400, 1440, 24, 0.142857, 0.0328767, 0.00273973}, //Tiempo
            new double []{1,1e+6,0.386102,1.19599,10,7639,1550,1e-4}
        };
           
            {
                double cantidad = double.Parse(cboCantidad.Text);
                int tipo = cboTipoconversor.SelectedIndex;
                int de = cboDe.SelectedIndex;
                int a = cboA.SelectedIndex;
               
                double respuesta = cantidad * valores[tipo][a] / valores[tipo][de];

                label3.Text = "RESPUESTA: " + respuesta.ToString("N2");
            }
        }

        private void cboTipoconversor_SelectedIndexChanged(object sender, EventArgs e)

        {
            string[][] etiquetas = new string[][]
            {
                new string [] {"Dolar","pesos mexicanos","quetzal","lempira","colon SV"},//monedas
                new string[]{"metros","cm","pulgadas","pie","varas","yardas","metro cuadrado","kilometro cuadrado"},
               new string[]{ "libra", "onza", "gramo", "kg" },
         new string[]{ "galon", "litros", "pinta", "ml" },
          new string[]{ "GB", "bite", "kb", "mb" },
            };
            cboDe.Items.Clear();
            cboA.Items.Clear();
            cboDe.Items.AddRange(etiquetas[cboTipoconversor.SelectedIndex]);
            cboA.Items.AddRange(etiquetas[cboTipoconversor.SelectedIndex]);
        }
    }
    }

