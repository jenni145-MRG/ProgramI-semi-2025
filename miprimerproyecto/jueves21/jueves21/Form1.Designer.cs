namespace jueves21
{
    partial class Form1
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
            this.cboCantidad = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.cboTipoconversor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboA = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboCantidad
            // 
            this.cboCantidad.Location = new System.Drawing.Point(138, 268);
            this.cboCantidad.Name = "cboCantidad";
            this.cboCantidad.Size = new System.Drawing.Size(100, 22);
            this.cboCantidad.TabIndex = 1;
            this.cboCantidad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(43, 84);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(29, 16);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "respuesta : ?";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(426, 122);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(160, 93);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "calcular";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // cboTipoconversor
            // 
            this.cboTipoconversor.FormattingEnabled = true;
            this.cboTipoconversor.Items.AddRange(new object[] {
            "moneda",
            "longitud",
            "masa",
            "volumen",
            "almacenamiento",
            "tiempo"});
            this.cboTipoconversor.Location = new System.Drawing.Point(90, 81);
            this.cboTipoconversor.Name = "cboTipoconversor";
            this.cboTipoconversor.Size = new System.Drawing.Size(121, 24);
            this.cboTipoconversor.TabIndex = 6;
            this.cboTipoconversor.SelectedIndexChanged += new System.EventHandler(this.cboTipoconversor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "De";
            // 
            // cboDe
            // 
            this.cboDe.FormattingEnabled = true;
            this.cboDe.Items.AddRange(new object[] {
            "moneda",
            "longitud",
            "masa",
            "volumen",
            "almacenamiento",
            "tiempo"});
            this.cboDe.Location = new System.Drawing.Point(90, 142);
            this.cboDe.Name = "cboDe";
            this.cboDe.Size = new System.Drawing.Size(121, 24);
            this.cboDe.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "A";
            // 
            // cboA
            // 
            this.cboA.FormattingEnabled = true;
            this.cboA.Items.AddRange(new object[] {
            "moneda",
            "longitud",
            "masa",
            "volumen",
            "almacenamiento",
            "tiempo"});
            this.cboA.Location = new System.Drawing.Point(90, 202);
            this.cboA.Name = "cboA";
            this.cboA.Size = new System.Drawing.Size(121, 24);
            this.cboA.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboDe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipoconversor);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cboCantidad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cboCantidad;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.ComboBox cboTipoconversor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboA;
    }
}

