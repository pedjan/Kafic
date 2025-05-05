using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Kafic
{
    public partial class PojedinacanSto : Form
    {
        Baza baza = new Baza();
        Porudzbina porudzbina = new Porudzbina();
        private Pocetna parentForm;
        double ukupnoC;
        public PojedinacanSto(Sto sto, Pocetna parent)
        {
            InitializeComponent();
            this.Text = sto.getIme();
            this.parentForm = parent;
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void UpdateSto1Text(string newText)
        {
            if (parentForm != null)
            {
                parentForm.getSto1().Text = newText; // Ensure sto1 is accessible
            }
        }
        private void item_Click(object sender, EventArgs e)
        {
            string ime = (sender as Button).Text;
            Proizvod p = baza.getProizvodByName(ime);
            //if (porudzbine.Text.Equals("Nema porudzbina"))
            //{
                //porudzbine.Text = $"{"Ime",-9} {"Cena",18} {"Kolicina",18} {"Ukupno",9}\n\n";
            //}
            double cena = p.getCena();
            int kolicina = 2;
            //porudzbine.Text += $"{p.getIme(),-9} {cena,18} {"1",18} {cena * kolicina,9} \n";
            ukupnoC += cena * kolicina;
            ukupno.Text = "UKUPNO: " + ukupnoC;
            //Console.WriteLine(porudzbine.Text);
            string[] eto = { p.getIme(), p.getCena().ToString(), "1", (cena * kolicina).ToString()};
            ListViewItem item = new ListViewItem(eto);
            test.Items.Add(item);
            ukupno.Text = "UKUPNO: " + ukupnoC;
            UpdateSto1Text(ukupnoC + "");
        }
    }
}
