using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafic
{
    public partial class UpravljanjeProizvodima : Form
    {
        private Pocetna parentForm;
        private Baza baza = new Baza();

        public UpravljanjeProizvodima(Pocetna parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Hide();
        }

        private void nazadP_Click(object sender, EventArgs e)
        {
            nabavka.Visible = true;
            stanje.Visible = true;
            izmeniKol.Visible = true;

            labelVrsta.Visible = false;
            comboBox1.Visible = false;
            labelPrizvod.Visible = false;
            comboBox2.Visible = false;
            comboBox2.Items.Clear();
            labelKolicina.Visible = false;
            numericUpDown1.Visible = false;
            buttonDodaj.Visible = false;

            naslovRadnje.Visible = false;

            labelProizvodi.Visible = false;

            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            this.nazad.Click -= new System.EventHandler(this.nazadP_Click);

        }

        private void nabavka_Click(object sender, EventArgs e)
        {
            this.nazad.Click -= new System.EventHandler(this.nazad_Click);
            this.nazad.Click += new System.EventHandler(this.nazadP_Click);

            nabavka.Visible = false;
            stanje.Visible = false;
            izmeniKol.Visible = false;

            labelVrsta.Visible = true;
            comboBox1.Visible = true;

            naslovRadnje.Visible = true;
            naslovRadnje.Text = "Nabavka proizvoda";

            //vrste = baza.getVrste();

            //foreach (Vrsta vrsta in vrste)
            //{
            //    Button vrstaBtn = new Button
            //    {
            //        Text = vrsta.getIme(),
            //        Location = new Point(461 + 72 * (vrsta.getIdV() - 1), 12),
            //        BackColor = Color.White,
            //        //FlatAppearance.BorderSize = 0,
            //        FlatStyle = System.Windows.Forms.FlatStyle.Flat
            //    };
            //    vrstaBtn.FlatAppearance.BorderSize = 0;
            //    vrstaBtn.Click += vrstaBtn_Click;
            //    vrsteBtn.Add(vrstaBtn);
            //    this.Controls.Add(vrstaBtn);
            //}


        }

        private void UpravljanjeProizvodima_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.vrsta' table. You can move, or remove it, as needed.
            this.vrstaTableAdapter.Fill(this.bazaDataSet.vrsta);

        }

        private void izabranaVrsta(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            Vrsta v = baza.getVrstaById(comboBox1.SelectedIndex + 1);
            List<Proizvod> proizvodi = baza.getProizvodiByVrsta(v.getIdV());
            foreach (Proizvod proizvod in proizvodi)
            {
                comboBox2.Items.Add(proizvod.getIme());
            }
            labelPrizvod.Visible = true;
            comboBox2.Visible = true;
        }

        private void izabanProizvod(object sender, EventArgs e)
        {
            labelKolicina.Visible = true;
            numericUpDown1.Visible = true;
            buttonDodaj.Visible = true;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value < 1)
            {
                MessageBox.Show("Količina mora biti veća od 0.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else {
                uint kolicina = (uint)numericUpDown1.Value;
                baza.dodajKolicinuZaProizvod(comboBox2.SelectedItem.ToString(), kolicina);
                MessageBox.Show("Uspesno ste dodali " + kolicina + " komada za proizvod: " + comboBox2.Text, "Uspesno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelPrizvod.Visible = false;
                comboBox2.Visible = false;
                labelKolicina.Visible = false;
                numericUpDown1.Visible = false;
                buttonDodaj.Visible = false;
                comboBox2.Items.Clear();
            }

        }

        private void stanje_Click(object sender, EventArgs e)
        {
            this.nazad.Click -= new System.EventHandler(this.nazad_Click);
            this.nazad.Click += new System.EventHandler(this.nazadP_Click);

            nabavka.Visible = false;
            stanje.Visible = false;
            izmeniKol.Visible = false;

            naslovRadnje.Visible = true;
            naslovRadnje.Text = "Stanje proizvoda";

            List<Proizvod> proizvodi = baza.getSveProizvode();
            string format = String.Format("{0,-5} {1,-20} {2,-25} {3,-10} {4,-10}\n\n", "ID", "Ime", "Vrsta", "Cena", "Količina");
            foreach (Proizvod proizvod in proizvodi)
            {
                format += String.Format("{0,-5} {1,-20} {2,-25} {3,-10} {4,-10}\n", proizvod.getId(), proizvod.getIme(), proizvod.getVrstaIme(), proizvod.getCena(), proizvod.getKolicina());
            }
            labelProizvodi.Text = format;
            labelProizvodi.Visible = true;
        }
    }
}
