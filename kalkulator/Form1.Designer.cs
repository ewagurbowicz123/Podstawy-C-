namespace kalkulator
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxkwotapocz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxkwotawydatki = new System.Windows.Forms.TextBox();
            this.listBox1kategoria = new System.Windows.Forms.ListBox();
            this.kategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(768, 69);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(326, 50);
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(52, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "wpisz kwotę początkową";
            // 
            // textBoxkwotapocz
            // 
            this.textBoxkwotapocz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxkwotapocz.Location = new System.Drawing.Point(60, 86);
            this.textBoxkwotapocz.Name = "textBoxkwotapocz";
            this.textBoxkwotapocz.Size = new System.Drawing.Size(272, 29);
            this.textBoxkwotapocz.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(52, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "wpisz kwotę wydatków";
            // 
            // textBoxkwotawydatki
            // 
            this.textBoxkwotawydatki.Location = new System.Drawing.Point(65, 377);
            this.textBoxkwotawydatki.Name = "textBoxkwotawydatki";
            this.textBoxkwotawydatki.Size = new System.Drawing.Size(188, 20);
            this.textBoxkwotawydatki.TabIndex = 4;
            // 
            // listBox1kategoria
            // 
            this.listBox1kategoria.FormattingEnabled = true;
            this.listBox1kategoria.Location = new System.Drawing.Point(335, 367);
            this.listBox1kategoria.Name = "listBox1kategoria";
            this.listBox1kategoria.Size = new System.Drawing.Size(196, 30);
            this.listBox1kategoria.TabIndex = 5;
            this.listBox1kategoria.SelectedIndexChanged += new System.EventHandler(this.listBox1kategoria_SelectedIndexChanged);
            // 
            // kategoria
            // 
            this.kategoria.Location = new System.Drawing.Point(328, 416);
            this.kategoria.Name = "kategoria";
            this.kategoria.Size = new System.Drawing.Size(216, 21);
            this.kategoria.TabIndex = 6;
            this.kategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 672);
            this.Controls.Add(this.kategoria);
            this.Controls.Add(this.listBox1kategoria);
            this.Controls.Add(this.textBoxkwotawydatki);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxkwotapocz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxkwotapocz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxkwotawydatki;
        private System.Windows.Forms.ListBox listBox1kategoria;
        private System.Windows.Forms.ComboBox kategoria;
    }
}

