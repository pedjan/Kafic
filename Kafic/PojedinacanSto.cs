﻿using System;
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
            parentForm.Show();
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

            if (kolicina > p.getKolicina())
            {
                MessageBox.Show("Nemamo dovoljno proizvoda na stanju");
                return;
            } 
            else 
            {
                ukupnoC += cena * kolicina;
                ukupno.Text = "UKUPNO: " + ukupnoC;
                string[] eto = { p.getIme(), p.getCena().ToString(), kolicina.ToString(), (cena * kolicina).ToString() };
                ListViewItem item = new ListViewItem(eto);
                test.Items.Add(item);
                ukupno.Text = "UKUPNO: " + ukupnoC;
                UpdateStoCena(this.Text, ukupnoC.ToString());
            }
        }

        private uint getKolicina()
        {
            var formKolicina = new Form();

            Label text = new Label
            {
                Text = "Unesite kolicinu",
                Location = new Point(100, 20),
                Size = new Size(200, 20)
            };
            formKolicina.Controls.Add(text);

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

        private void naplati_Click(object sender, EventArgs e)
        {
            Form naplata = new Form();

            naplata.FormBorderStyle = FormBorderStyle.None;

            TextBox iznos = new TextBox { Location = new Point(90, 50) };
            naplata.Controls.Add(iznos);

            Label text = new Label
            {
                Text = "Unesite iznos koji zelite da platite",
                Location = new Point(70, 20),
                Size = new Size(200, 20)
            };
            naplata.Controls.Add(text);

            Button confirmButton = new Button
            {
                Text = "Naplati",
                Location = new Point(100, 100),
                Size = new Size(75, 30)
            };
            naplata.Controls.Add(confirmButton);

            confirmButton.Click += (senderr, ee) =>
            {
                naplata.Hide();
            };

            naplata.ShowDialog();

            double iznosBroj;
            bool isNumeric = double.TryParse(iznos.Text, out iznosBroj);
            while (!isNumeric || ukupnoC > iznosBroj)
            {
                MessageBox.Show("Moras uneti ispravan izraz racuna koji iznosi " + ukupnoC + "RSD");
                naplata.ShowDialog();
                isNumeric = double.TryParse(iznos.Text, out iznosBroj);
                
            }

            foreach (var item in test.Items) {
                ListViewItem item1 = (ListViewItem)item;
                string ime = item1.SubItems[0].Text;
                uint kolicina = uint.Parse(item1.SubItems[2].Text);
                baza.updateProizvod(ime, kolicina);
            }

            double kusur = iznosBroj - ukupnoC;
            MessageBox.Show("Uspesno ste platili racun\nKusur iznosi: " + Math.Round(kusur, 2) + "RSD");
            ukupnoC = 0;
            ukupno.Text = "UKUPNO: " + ukupnoC;
            UpdateStoCena(this.Text, String.Empty);
            test.Items.Clear();


        }
    }
}
