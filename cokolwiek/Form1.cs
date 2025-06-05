using KalkulatorBudzetuDomowego;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cokolwiek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbKategoria.Items.AddRange(new string[] { "Jedzenie", "Transport", "Rachunki", "Koncerty", "Inne", "Higiena" });
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

    }
}
