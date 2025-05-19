using System;

namespace math_quiz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            timeleft1.Tick += new EventHandler(timer1_Tick);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plusleftlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plusrightlabe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.suma = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.minusrightlabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minusleftlabel = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.timesrightlabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timesleftlabel = new System.Windows.Forms.Label();
            this.iloraz = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.devidedrightlabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.devidedleftlabel = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.timeleft1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.suma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloraz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(105, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "pozostały czas:";
            // 
            // plusleftlabel
            // 
            this.plusleftlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusleftlabel.Location = new System.Drawing.Point(33, 75);
            this.plusleftlabel.Name = "plusleftlabel";
            this.plusleftlabel.Size = new System.Drawing.Size(60, 50);
            this.plusleftlabel.TabIndex = 2;
            this.plusleftlabel.Text = "?";
            this.plusleftlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(119, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "+";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusrightlabe
            // 
            this.plusrightlabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusrightlabe.Location = new System.Drawing.Point(185, 75);
            this.plusrightlabe.Name = "plusrightlabe";
            this.plusrightlabe.Size = new System.Drawing.Size(60, 50);
            this.plusrightlabe.TabIndex = 4;
            this.plusrightlabe.Text = "?";
            this.plusrightlabe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(267, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 5;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // suma
            // 
            this.suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.suma.Location = new System.Drawing.Point(333, 84);
            this.suma.MaximumSize = new System.Drawing.Size(100, 0);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(87, 35);
            this.suma.TabIndex = 1;
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difference.Location = new System.Drawing.Point(333, 134);
            this.difference.MaximumSize = new System.Drawing.Size(100, 0);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(87, 35);
            this.difference.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(267, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 10;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusrightlabel
            // 
            this.minusrightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minusrightlabel.Location = new System.Drawing.Point(185, 125);
            this.minusrightlabel.Name = "minusrightlabel";
            this.minusrightlabel.Size = new System.Drawing.Size(60, 50);
            this.minusrightlabel.TabIndex = 9;
            this.minusrightlabel.Text = "?";
            this.minusrightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(119, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 8;
            this.label7.Text = "-";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusleftlabel
            // 
            this.minusleftlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minusleftlabel.Location = new System.Drawing.Point(33, 125);
            this.minusleftlabel.Name = "minusleftlabel";
            this.minusleftlabel.Size = new System.Drawing.Size(60, 50);
            this.minusleftlabel.TabIndex = 7;
            this.minusleftlabel.Text = "?";
            this.minusleftlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.product.Location = new System.Drawing.Point(333, 184);
            this.product.MaximumSize = new System.Drawing.Size(100, 0);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(87, 35);
            this.product.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(267, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 15;
            this.label9.Text = "=";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesrightlabel
            // 
            this.timesrightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesrightlabel.Location = new System.Drawing.Point(185, 175);
            this.timesrightlabel.Name = "timesrightlabel";
            this.timesrightlabel.Size = new System.Drawing.Size(60, 50);
            this.timesrightlabel.TabIndex = 14;
            this.timesrightlabel.Text = "?";
            this.timesrightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(119, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 13;
            this.label11.Text = "x";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesleftlabel
            // 
            this.timesleftlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesleftlabel.Location = new System.Drawing.Point(33, 175);
            this.timesleftlabel.Name = "timesleftlabel";
            this.timesleftlabel.Size = new System.Drawing.Size(60, 50);
            this.timesleftlabel.TabIndex = 12;
            this.timesleftlabel.Text = "?";
            this.timesleftlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iloraz
            // 
            this.iloraz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloraz.Location = new System.Drawing.Point(333, 234);
            this.iloraz.MaximumSize = new System.Drawing.Size(100, 0);
            this.iloraz.Name = "iloraz";
            this.iloraz.Size = new System.Drawing.Size(87, 35);
            this.iloraz.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(267, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 50);
            this.label13.TabIndex = 20;
            this.label13.Text = "=";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // devidedrightlabel
            // 
            this.devidedrightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.devidedrightlabel.Location = new System.Drawing.Point(185, 225);
            this.devidedrightlabel.Name = "devidedrightlabel";
            this.devidedrightlabel.Size = new System.Drawing.Size(60, 50);
            this.devidedrightlabel.TabIndex = 19;
            this.devidedrightlabel.Text = "?";
            this.devidedrightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(119, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 50);
            this.label15.TabIndex = 18;
            this.label15.Text = "÷";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // devidedleftlabel
            // 
            this.devidedleftlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.devidedleftlabel.Location = new System.Drawing.Point(33, 225);
            this.devidedleftlabel.Name = "devidedleftlabel";
            this.devidedleftlabel.Size = new System.Drawing.Size(60, 50);
            this.devidedleftlabel.TabIndex = 17;
            this.devidedleftlabel.Text = "?";
            this.devidedleftlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startbutton
            // 
            this.startbutton.AutoSize = true;
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startbutton.Location = new System.Drawing.Point(141, 298);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(169, 51);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "rozpocznij quiz";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // timeleft1
            // 
            this.timeleft1.Interval = 1000;
            this.timeleft1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.iloraz);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.devidedrightlabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.devidedleftlabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.timesrightlabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.timesleftlabel);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minusrightlabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minusleftlabel);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.plusrightlabe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plusleftlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloraz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label plusleftlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label plusrightlabe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown suma;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label minusrightlabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label minusleftlabel;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label timesrightlabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label timesleftlabel;
        private System.Windows.Forms.NumericUpDown iloraz;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label devidedrightlabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label devidedleftlabel;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Timer timeleft1;

    }
}

