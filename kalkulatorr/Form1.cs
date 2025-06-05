using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulatorr
{
    public partial class Form1 : Form
    {
        decimal sumaZarobkow = 0;
        decimal sumaWydatkow = 0;
        Dictionary<string, decimal> wydatkiSpecjalne = new Dictionary<string, decimal>
        {
            { "Ubezpieczenie", 0 },
            { "Zakupy", 0 }
            , { "Jedzenie", 0 },
            { "Transport", 0 },
            { "Inne", 0 },
            {"Rachunki",0 },
            {"Media",0 },
            {"Zdrowie",0 }
        };


        public Form1()
        {
            InitializeComponent();
            cbzarobki.Items.AddRange(new string[] { "Wynagrodzenie", "Premia", "Inwestycja", "Sprzedaz online", "Inne" });
            cbwydatki.Items.AddRange(new string[] { "Czynsz", "Media", "Ubezpieczenie", "Zakupy", "Jedzenie", "Transport", "Zdrowie" , "Inne" });

            cbzarobki.SelectedIndex = 0;
            cbwydatki.SelectedIndex = 0;

            pb.Minimum = 0;
            pb.Maximum = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pb_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal kwota) && kwota > 0)
            {
                string kategoria = cbzarobki.SelectedItem.ToString();
                sumaZarobkow += kwota;

                tvzarobki.Nodes.Add($"{kategoria}: +{kwota} zł");

                textBox1.Clear();
                Update();
            }
            else
            {
                MessageBox.Show("Wprowadź poprawną kwotę zarobków!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox2.Text, out decimal kwota) && kwota > 0)
            {
                string kategoria = cbwydatki.SelectedItem.ToString();
                sumaWydatkow += kwota;
                ostatniaKategoriaWydatek = kategoria;
                tvwydatki.Nodes.Add($"{kategoria}: -{kwota} zł");

                
                if (wydatkiSpecjalne.ContainsKey(kategoria))
                {
                    wydatkiSpecjalne[kategoria] += kwota;
                }

                textBox2.Clear();
                AktualizujProgressBar();
            }
            else
            {
                MessageBox.Show("Wprowadź poprawną kwotę wydatków!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal pozostalo = sumaZarobkow - sumaWydatkow;
            string raport = $"Zarobki: {sumaZarobkow} zł\n" +
                            $"Wydatki: {sumaWydatkow} zł\n" +
                            $"Pozostało: {pozostalo} zł";
            MessageBox.Show(raport, "Raport budżetu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }






        private string ostatniaKategoriaWydatek = "";

        private void AktualizujProgressBar()
        {
            decimal sumaSpecjalnych = wydatkiSpecjalne.Values.Sum();
            if (sumaZarobkow > 0)
            {
                int procent = (int)((sumaSpecjalnych / sumaZarobkow) * 100);
                pb.Value = Math.Min(procent, 100);
            }
            else
            {
                pb.Value = 0;
            }

            
            switch (ostatniaKategoriaWydatek)
            {
                case "Ubezpieczenie":
                    pb.ForeColor = System.Drawing.Color.Blue;
                    break;
                case "Zakupy":
                    pb.ForeColor = System.Drawing.Color.Green;
                    break;
                case "Jedzenie":
                    pb.ForeColor = System.Drawing.Color.Orange;
                    break;
                case "Transport":
                    pb.ForeColor = System.Drawing.Color.Purple;
                    break;
                case "Inne":
                    pb.ForeColor = System.Drawing.Color.Gray;
                    break;
                default:
                    pb.ForeColor = System.Drawing.Color.Black;
                    break;
            }
        }

        private void pb_Click_1(object sender, EventArgs e)
        {

        }
    }
}

