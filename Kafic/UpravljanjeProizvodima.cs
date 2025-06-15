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
        private int opcija;

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
            izvestaji.Visible = true;
            buttonStanjeKasa.Visible = true;

            labelVrsta.Visible = false;
            comboBox1.Visible = false;
            labelPrizvod.Visible = false;
            comboBox2.Visible = false;
            comboBox2.Items.Clear();
            labelKolicina.Visible = false;
            numericUpDown1.Visible = false;
            buttonDodaj.Visible = false;
            naslovRadnje.Visible = false;
            dateTimePicker1.Visible = false;
            labelTrenutnaKolicina.Visible = false;
            

            labelDatum.Visible = false;

            proizvodiTB.Visible = false;

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
            izvestaji.Visible = false;
            buttonStanjeKasa.Visible = false;

            labelVrsta.Visible = true;
            comboBox1.Visible = true;

            naslovRadnje.Visible = true;
            naslovRadnje.Text = "Nabavka proizvoda";
            opcija = 0;

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
            labelKolicina.Text = "Izberi kolicinu: ";
            labelKolicina.Visible = true;
            numericUpDown1.Visible = true;
            buttonDodaj.Visible = true;
            labelTrenutnaKolicina.Visible = true;
            labelTrenutnaKolicina.Text = "Trenutna količina: " + baza.getProizvodByName(comboBox2.SelectedItem.ToString()).getKolicina();
            if (opcija == 1) {
                buttonDodaj.Text = "Izmeni";

            } else {
                buttonDodaj.Text = "Dodaj";
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {

            if (opcija != 2 && numericUpDown1.Value < 1)
            {
                MessageBox.Show("Količina mora biti veća od 0.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                uint kolicina = (uint)numericUpDown1.Value;
                if (opcija == 1)
                {
                    if(comboBox2.Text == null || comboBox2.SelectedItem == null)
                    {
                        MessageBox.Show("Morate izabrati proizvod.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    baza.kolicinaProizvoda(comboBox2.SelectedItem.ToString(), kolicina);
                    MessageBox.Show("Uspesno ste postavili " + kolicina + " komada za proizvod: " + comboBox2.Text, "Uspesno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (opcija == 2)
                {
                    DateTime datum = dateTimePicker1.Value;
                    naslovRadnje.Text = "Prikaz pazara za dan: " + datum.ToString().Substring(0, 10);
                    List<Pazar> lista = baza.getPazar(datum);
                    int zarada = 0;
                    string format = String.Format("{0,-20} {1,-10}\n\n", "Proizvod", "Količina");
                    format += String.Format("{0,-20} {1,-10}", "", "");
                    foreach (Pazar p in lista)
                    {
                        format += String.Format("{0,-20} {1,-10}\n", p.Proizvod, p.Kolicina);
                        zarada += p.Kolicina * (int)baza.getProizvodByName(p.Proizvod).getCena();
                    }
                    format += String.Format("{0,-100}", "");
                    format += "\nUKUPNA ZARADA: " + zarada + "RSD";
                    proizvodiTB.Text = format;
                    proizvodiTB.Size = new Size(280, 500);
                    proizvodiTB.Visible = true;

                }
                else if (opcija == 4)
                {
                    int kasa = baza.getKasa() - (int)kolicina;
                    if (kasa < 0)
                    {
                        MessageBox.Show("Nema dovoljno novca u kasi.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    baza.updateKasa(-(int)kolicina);
                    MessageBox.Show("Uspesno ste izvadili " + kolicina + " RSD iz kase. Trenutno stanje: " + kasa + "RSD", "Uspesno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    naslovRadnje.Text = "Izmena stanja kase, trenurno: " + kasa + "RSD";
                }
                else
                {
                    if (comboBox2.Text == null || comboBox2.SelectedItem == null)
                    {
                        MessageBox.Show("Morate izabrati proizvod.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    baza.dodajKolicinuZaProizvod(comboBox2.SelectedItem.ToString(), kolicina);
                    MessageBox.Show("Uspesno ste dodali " + kolicina + " komada za proizvod: " + comboBox2.Text, "Uspesno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                labelPrizvod.Visible = false;
                comboBox2.Visible = false;
                numericUpDown1.Value = 0;
                if (opcija != 4) {
                    labelKolicina.Visible = false;
                    numericUpDown1.Visible = false;
                    buttonDodaj.Visible = false;
                }
                
                dateTimePicker1.Visible = false;
                labelDatum.Visible = false;
                labelTrenutnaKolicina.Visible = false;
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
            izvestaji.Visible = false;
            buttonStanjeKasa.Visible = false;

            naslovRadnje.Visible = true;
            naslovRadnje.Text = "Stanje proizvoda";

            List<Proizvod> proizvodi = baza.getSveProizvode();
            string format = String.Format("{0,-5} {1,-20} {2,-25} {3,-10} {4,-10}\n\n", "ID", "Ime", "Vrsta", "Cena", "Količina");
            format += String.Format("{0,-5} {1,-20} {2,-25} {3,-10} {4,-10}\n\n", "", "", "", "", "");
            foreach (Proizvod proizvod in proizvodi)
            {
                format += String.Format("{0,-5} {1,-20} {2,-25} {3,-10} {4,-10}\n", proizvod.getId(), proizvod.getIme(), proizvod.getVrstaIme(), proizvod.getCena(), proizvod.getKolicina());
            }
            proizvodiTB.Text = format;
            proizvodiTB.Size = new Size(614, 487);
            proizvodiTB.Visible = true;

        }

        private void izmeniKol_Click(object sender, EventArgs e)
        {
            this.nazad.Click -= new System.EventHandler(this.nazad_Click);
            this.nazad.Click += new System.EventHandler(this.nazadP_Click);

            nabavka.Visible = false;
            stanje.Visible = false;
            izmeniKol.Visible = false;
            izvestaji.Visible = false;
            buttonStanjeKasa.Visible = false;

            labelVrsta.Visible = true;
            comboBox1.Visible = true;

            naslovRadnje.Visible = true;
            naslovRadnje.Text = "Izmena kolicine";

            opcija = 1;
        }

        private void izvestaji_Click(object sender, EventArgs e)
        {
            this.nazad.Click -= new System.EventHandler(this.nazad_Click);
            this.nazad.Click += new System.EventHandler(this.nazadP_Click);

            nabavka.Visible = false;
            stanje.Visible = false;
            izmeniKol.Visible = false;
            izvestaji.Visible = false;
            buttonStanjeKasa.Visible = false;

            labelDatum.Visible = true;
            buttonDodaj.Text = "Prikaži";
            buttonDodaj.Visible = true;

            naslovRadnje.Visible = true;
            naslovRadnje.Text = "Prikaz pazara za dan";
            dateTimePicker1.Visible = true;

            opcija = 2;
        }

        private void buttonStanjeKasa_Click(object sender, EventArgs e)
        {
            this.nazad.Click -= new System.EventHandler(this.nazad_Click);
            this.nazad.Click += new System.EventHandler(this.nazadP_Click);

            nabavka.Visible = false;
            stanje.Visible = false;
            izmeniKol.Visible = false;
            izvestaji.Visible = false;
            buttonStanjeKasa.Visible = false;

            buttonDodaj.Text = "Izmeni";
            buttonDodaj.Visible = true;

            labelKolicina.Text = "Izvadi iz kase: ";
            labelKolicina.Visible = true;
            numericUpDown1.Visible = true;

            naslovRadnje.Visible = true;
            naslovRadnje.Text = "Izmena stanja kase, trenurno: " + baza.getKasa() + "RSD";
            opcija = 4;
        }


    }
}
