namespace creaciondelprimerprograma
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(252, 73);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 0;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(202, 76);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(45, 16);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "Num1:";
            // 
            // btn
            // 
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.Location = new System.Drawing.Point(252, 255);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(87, 38);
            this.btn.TabIndex = 2;
            this.btn.Text = "Calcular";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(201, 143);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(45, 16);
            this.lblNum2.TabIndex = 4;
            this.lblNum2.Text = "Num2:";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(252, 137);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 22);
            this.txtNum2.TabIndex = 3;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(244, 201);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(73, 16);
            this.lblRespuesta.TabIndex = 5;
            this.lblRespuesta.Text = "Respuesta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblRespuesta;
    }
}

