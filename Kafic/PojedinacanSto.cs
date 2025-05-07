using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
        private Pocetna parentForm;
        double ukupnoC;
        public PojedinacanSto(Sto sto, Pocetna parent)
        {
            InitializeComponent();
            this.Text = sto.getIme();
            this.parentForm = parent;
            ukupno.Text = String.Empty;
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void UpdateStoCena(string sto, string novaCena)
        {
            parentForm.getStoByName(sto).Text = novaCena;
        }
        private void item_Click(object sender, EventArgs e)
        {
            string ime = (sender as Button).Text;
            Proizvod p = baza.getProizvodByName(ime);
            double cena = p.getCena();
            uint kolicina = getKolicina();
            ukupnoC += cena * kolicina;
            ukupno.Text = "UKUPNO: " + ukupnoC;
            string[] eto = { p.getIme(), p.getCena().ToString(), kolicina.ToString(), (cena * kolicina).ToString()};
            ListViewItem item = new ListViewItem(eto);
            test.Items.Add(item);
            ukupno.Text = "UKUPNO: " + ukupnoC;
            UpdateStoCena(this.Text, ukupnoC.ToString());
        }

        private uint getKolicina() {
            var formKolicina = new Form();

            Button confirmButton = new Button
            {
                Text = "Potvrdi",
                Location = new Point(100, 100),
                Size = new Size(75, 30)
            };
            formKolicina.Controls.Add(confirmButton);

            TextBox kolicina = new TextBox { Location = new Point(90, 50) };
            formKolicina.Controls.Add(kolicina);

            confirmButton.Click += (sender, e) =>
            {
                formKolicina.Hide();
            };

            formKolicina.FormBorderStyle = FormBorderStyle.None;

            formKolicina.ShowDialog();

            uint kolicinaBroj;
            bool isNumeric = uint.TryParse(kolicina.Text, out kolicinaBroj);
            while (!isNumeric)
            {
                MessageBox.Show("Kolicina mora biti broj veci od 0");
                formKolicina.ShowDialog();
                isNumeric = uint.TryParse(kolicina.Text, out kolicinaBroj);
            }
            
            return kolicinaBroj;
        }
    }
}
