using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                new string[]{"metros","cm","pulgadas","pie","varas","yardas"},
               new string[]{ "libra", "onza", "gramo", "kg" },
         new string[]{ "galon", "litros", "pinta", "ml" },
          new string[]{ "GB", "bite", "kb", "mb" }
            };

        }

        private void cboTipoconversor_SelectedIndexChanged(object sender, EventArgs e)

        {
            string[][] etiquetas = new string[][]
            {
                new string [] {"Dolar","pesos mexicanos","quetzal","lempira","colon SV"},//monedas
                new string[]{"metros","cm","pulgadas","pie","varas","yardas"},
               new string[]{ "libra", "onza", "gramo", "kg" },
         new string[]{ "galon", "litros", "pinta", "ml" },
          new string[]{ "GB", "bite", "kb", "mb" }, };
            cboDe.Items.Clear();
            cboA.Items.Clear();
            cboDe.Items.AddRange(etiquetas[cboTipoconversor.SelectedIndex]);
            cboA.Items.AddRange(etiquetas[cboTipoconversor.SelectedIndex]);
        }
    }
    }

