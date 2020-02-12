namespace estadistica
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
            this.lblserie = new System.Windows.Forms.Label();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.lblrespuesta_serie = new System.Windows.Forms.Label();
            this.btnmediaritmetica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(48, 59);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(31, 13);
            this.lblserie.TabIndex = 0;
            this.lblserie.Text = "Serie";
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(113, 59);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(95, 20);
            this.txtserie.TabIndex = 1;
            this.txtserie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblrespuesta_serie
            // 
            this.lblrespuesta_serie.AutoSize = true;
            this.lblrespuesta_serie.Location = new System.Drawing.Point(48, 110);
            this.lblrespuesta_serie.Name = "lblrespuesta_serie";
            this.lblrespuesta_serie.Size = new System.Drawing.Size(12, 13);
            this.lblrespuesta_serie.TabIndex = 2;
            this.lblrespuesta_serie.Text = "x";
            this.lblrespuesta_serie.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnmediaritmetica
            // 
            this.btnmediaritmetica.Location = new System.Drawing.Point(51, 159);
            this.btnmediaritmetica.Name = "btnmediaritmetica";
            this.btnmediaritmetica.Size = new System.Drawing.Size(75, 23);
            this.btnmediaritmetica.TabIndex = 3;
            this.btnmediaritmetica.Text = "calcular x";
            this.btnmediaritmetica.UseVisualStyleBackColor = true;
            this.btnmediaritmetica.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 293);
            this.Controls.Add(this.btnmediaritmetica);
            this.Controls.Add(this.lblrespuesta_serie);
            this.Controls.Add(this.txtserie);
            this.Controls.Add(this.lblserie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Label lblrespuesta_serie;
        private System.Windows.Forms.Button btnmediaritmetica;
    }
}

