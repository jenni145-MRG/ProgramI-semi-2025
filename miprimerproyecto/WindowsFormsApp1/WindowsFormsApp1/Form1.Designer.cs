namespace WindowsFormsApp1
{
    partial class cbxItems
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbxVolumen = new System.Windows.Forms.ComboBox();
            this.cbxMasa = new System.Windows.Forms.ComboBox();
            this.cbxLongitud = new System.Windows.Forms.ComboBox();
            this.cbxAlmacenamiento = new System.Windows.Forms.ComboBox();
            this.cbxTiempo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Location = new System.Drawing.Point(393, 94);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(498, 97);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(69, 16);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(179, 95);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(115, 22);
            this.txtCantidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "cantidad a convertir:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MONEDAS",
            "Euro",
            "Yen Japones",
            "Libra Esterlina",
            "Dolar canadiense",
            "dolar australiano",
            "franco suizo",
            "Yuan chino",
            "dola de singapur",
            "peso mexicano",
            "real brasileño"});
            this.comboBox1.Location = new System.Drawing.Point(12, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // cbxVolumen
            // 
            this.cbxVolumen.FormattingEnabled = true;
            this.cbxVolumen.Items.AddRange(new object[] {
            "Kilometro a milla",
            "pie a metro",
            "pulgada a centimetro",
            "yarda a metro",
            "milla nautica a kilometro",
            "centimetro a milimetro",
            "metro a centimetro",
            "metro a kilometro",
            "yarda a pie",
            "milla a yarda "});
            this.cbxVolumen.Location = new System.Drawing.Point(266, 200);
            this.cbxVolumen.Name = "cbxVolumen";
            this.cbxVolumen.Size = new System.Drawing.Size(121, 24);
            this.cbxVolumen.TabIndex = 6;
            // 
            // cbxMasa
            // 
            this.cbxMasa.FormattingEnabled = true;
            this.cbxMasa.Items.AddRange(new object[] {
            "MASA",
            "Kilogramo a libra",
            "Gramo a onza",
            "Miligramo a gramo",
            "Tonelada a libra",
            "Libra a kilogramo",
            "Onza onza a gramo",
            "Quilate a gramo",
            "Stone a kilogramo",
            "Microgramo a miligramo",
            "Slug a kilogramo"});
            this.cbxMasa.Location = new System.Drawing.Point(139, 200);
            this.cbxMasa.Name = "cbxMasa";
            this.cbxMasa.Size = new System.Drawing.Size(121, 24);
            this.cbxMasa.TabIndex = 7;
            // 
            // cbxLongitud
            // 
            this.cbxLongitud.FormattingEnabled = true;
            this.cbxLongitud.Items.AddRange(new object[] {
            "Kilometro a milla",
            "Pie a Metro",
            "Pulgada a Centimetro",
            "Yarda a metro",
            "Milla nautica a Kilometro",
            "Centimetro a Milimetro",
            "Metro a Kilometro",
            "Yarda a Pie",
            "Milla  Yarda"});
            this.cbxLongitud.Location = new System.Drawing.Point(393, 200);
            this.cbxLongitud.Name = "cbxLongitud";
            this.cbxLongitud.Size = new System.Drawing.Size(121, 24);
            this.cbxLongitud.TabIndex = 8;
            // 
            // cbxAlmacenamiento
            // 
            this.cbxAlmacenamiento.FormattingEnabled = true;
            this.cbxAlmacenamiento.Items.AddRange(new object[] {
            "bit a byte",
            "byte a kilobyte",
            "kilobyte a megabyte",
            "megabyte a gigabyte",
            "gigabyte a terabyte",
            "terabyte a pentabyte",
            "pentabyte a exabyte",
            "exabyte a zettabyte",
            "zettabyte a yottabyte",
            "kbps a mbps"});
            this.cbxAlmacenamiento.Location = new System.Drawing.Point(520, 200);
            this.cbxAlmacenamiento.Name = "cbxAlmacenamiento";
            this.cbxAlmacenamiento.Size = new System.Drawing.Size(121, 24);
            this.cbxAlmacenamiento.TabIndex = 9;
            // 
            // cbxTiempo
            // 
            this.cbxTiempo.FormattingEnabled = true;
            this.cbxTiempo.Items.AddRange(new object[] {
            "segundo a minuto",
            "minuto a hora",
            "hora a dia",
            "dia a semana",
            "dia a año",
            "año a decada",
            "decada a siglo",
            "siglo a milenio",
            "año a lustro",
            "milisegundo a segundo"});
            this.cbxTiempo.Location = new System.Drawing.Point(647, 200);
            this.cbxTiempo.Name = "cbxTiempo";
            this.cbxTiempo.Size = new System.Drawing.Size(121, 24);
            this.cbxTiempo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "MONEDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "LONGITUD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "VOLUMEN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "ALMACENAMIENTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(686, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "TIEMPO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "MASA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "MASA";
            // 
            // cbxItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTiempo);
            this.Controls.Add(this.cbxAlmacenamiento);
            this.Controls.Add(this.cbxLongitud);
            this.Controls.Add(this.cbxMasa);
            this.Controls.Add(this.cbxVolumen);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Name = "cbxItems";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.cbxItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbxVolumen;
        private System.Windows.Forms.ComboBox cbxMasa;
        private System.Windows.Forms.ComboBox cbxLongitud;
        private System.Windows.Forms.ComboBox cbxAlmacenamiento;
        private System.Windows.Forms.ComboBox cbxTiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

