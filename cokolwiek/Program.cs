using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KalkulatorBudzetuDomowego
{
    public partial class cokolwiek
    {
        decimal budzetMiesieczny = 3000;
        decimal sumaWydatkow = 0;
        List<Wydatek> wydatki = new List<Wydatek>();

        public cokolwiek()
        {
            InitializeComponent();
            cmbKategoria.Items.AddRange(new string[] { "Jedzenie", "Transport", "Rachunki", "Rozrywka", "Inne" });
            cmbKategoria.SelectedIndex = 0;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtKwota.Text, out decimal kwota))
            {
                string kategoria = cmbKategoria.SelectedItem.ToString();
                DateTime data = dtpData.Value;

                Wydatek nowy = new Wydatek { Kategoria = kategoria, Kwota = kwota, Data = data };
                wydatki.Add(nowy);

                sumaWydatkow += kwota;
                AktualizujUI();
                txtKwota.Clear();
            }
            else
            {
                MessageBox.Show("Podaj poprawną kwotę.");
            }
        }

        private void AktualizujUI()
        {
            lblSuma.Text = "Suma wydatków: " + sumaWydatkow + " zł";
            lblPozostalo.Text = "Pozostały budżet: " + (budzetMiesieczny - sumaWydatkow) + " zł";
            progressBar1.Value = Math.Min((int)(sumaWydatkow / budzetMiesieczny * 100), 100);
            OdswiezListe();
        }

        private void OdswiezListe()
        {
            lstWydatki.Items.Clear();
            foreach (var w in wydatki)
            {
                lstWydatki.Items.Add($"{w.Data.ToShortDateString()} - {w.Kategoria} - {w.Kwota} zł");
            }
        }
    }

    public class Wydatek
    {
        public string Kategoria { get; set; }
        public decimal Kwota { get; set; }
        public DateTime Data { get; set; }
    }
}

