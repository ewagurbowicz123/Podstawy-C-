namespace cokolwiek
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKwota = new System.Windows.Forms.TextBox();
            this.cmbKategoria = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btndodaj = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblpozostało = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lstwydatki = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtKwota
            // 
            this.txtKwota.Location = new System.Drawing.Point(148, 151);
            this.txtKwota.Name = "txtKwota";
            this.txtKwota.Size = new System.Drawing.Size(238, 20);
            this.txtKwota.TabIndex = 0;
            // 
            // cmbKategoria
            // 
            this.cmbKategoria.FormattingEnabled = true;
            this.cmbKategoria.Location = new System.Drawing.Point(149, 195);
            this.cmbKategoria.Name = "cmbKategoria";
            this.cmbKategoria.Size = new System.Drawing.Size(197, 21);
            this.cmbKategoria.TabIndex = 1;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(149, 248);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(186, 20);
            this.dtpData.TabIndex = 2;
            // 
            // btndodaj
            // 
            this.btndodaj.Location = new System.Drawing.Point(136, 338);
            this.btndodaj.Name = "btndodaj";
            this.btndodaj.Size = new System.Drawing.Size(64, 28);
            this.btndodaj.TabIndex = 3;
            this.btndodaj.Text = "button1";
            this.btndodaj.UseVisualStyleBackColor = true;
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(521, 302);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(35, 13);
            this.lblSuma.TabIndex = 4;
            this.lblSuma.Text = "label1";
            // 
            // lblpozostało
            // 
            this.lblpozostało.AutoSize = true;
            this.lblpozostało.Location = new System.Drawing.Point(643, 356);
            this.lblpozostało.Name = "lblpozostało";
            this.lblpozostało.Size = new System.Drawing.Size(35, 13);
            this.lblpozostało.TabIndex = 5;
            this.lblpozostało.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(475, 395);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(97, 31);
            this.progressBar1.TabIndex = 6;
            // 
            // lstwydatki
            // 
            this.lstwydatki.FormattingEnabled = true;
            this.lstwydatki.Location = new System.Drawing.Point(657, 120);
            this.lstwydatki.Name = "lstwydatki";
            this.lstwydatki.Size = new System.Drawing.Size(152, 121);
            this.lstwydatki.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(948, 546);
            this.Controls.Add(this.lstwydatki);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblpozostało);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.btndodaj);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cmbKategoria);
            this.Controls.Add(this.txtKwota);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKwota;
        private System.Windows.Forms.ComboBox cmbKategoria;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btndodaj;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblpozostało;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox lstwydatki;
    }
}

