using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kafic
{
    public partial class PojedinacanSto : Form
    {
        private Baza baza = new Baza();
        private Pocetna parentForm;
        private double ukupnoC;
        public Sto sto;
        private List<Vrsta> vrste;
        private List<Button> proizvodiBtn = new List<Button>();
        private Form naplata;
        private TextBox iznos;

        private Form formKolicina;
        private bool isNumeric;
        private uint kolicinaBroj;
        private TextBox kolicina;

        private Form formIzmenaKolicine;
        private TextBox novaKolicinaT;
        private ListViewItem item;

        private Proizvod izabraniProizvod;

        public PojedinacanSto(Sto sto, Pocetna parent)
        {
            InitializeComponent();
            this.sto = sto;
            this.Text = sto.getIme();
            this.Name = sto.getIme();
            this.parentForm = parent;
            ukupno.Text = String.Empty;

            vrste = baza.getVrste();

            foreach (Vrsta vrsta in vrste)
            {
                Button vrstaBtn = new Button
                {
                    Text = vrsta.getIme(),
                    Location = new Point(461 + 72 * (vrsta.getIdV() - 1), 12),
                    BackColor = Color.White,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat
                };
                vrstaBtn.FlatAppearance.BorderSize = 0;
                vrstaBtn.Click += vrstaBtn_Click;
                this.Controls.Add(vrstaBtn);
            }

            List<Sto> stolovi = baza.getSveStolove();
            foreach (Sto s in stolovi)
            {
                comboBox1.Items.Add(s.getIme());
            }
            
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            if (proizvodiBtn.Count != 0)
            {
                foreach (Button btn in proizvodiBtn)
                {
                    this.Controls.Remove(btn);
                }
            }
            parentForm.Show();
            this.Hide();
        }

        private void UpdateStoCena(string sto, string novaCena)
        {
            
            if (string.IsNullOrEmpty(novaCena))
            {
                parentForm.GetStoByName(sto).BackColor = Color.LightGreen;
                parentForm.GetStoByName(sto).Text = sto;
            }
            else
            {
                parentForm.GetStoByName(sto).BackColor = Color.Red;
                parentForm.GetStoByName(sto).Text = sto + "\n\n" + novaCena;
            }
        }

        private void item_Click(object sender, EventArgs e)
        {
            string ime = (sender as Button).Text;
            izabraniProizvod = baza.getProizvodByName(ime);
            double cena = izabraniProizvod.getCena();
            getKolicina();
            uint kolicina = kolicinaBroj;

            if (kolicina == 0)
            {
                return;
            }

            if (kolicina > izabraniProizvod.getKolicina())
            {
                MessageBox.Show("Nemamo dovoljno proizvoda na stanju");
                return;
            } 
            else 
            {
                ukupnoC += cena * kolicina;
                bool found = false;
                foreach (ListViewItem itemm in test.Items)
                {
                    if (itemm.SubItems[0].Text.Equals(izabraniProizvod.getIme()))
                    {
                        itemm.SubItems[2].Text = (uint.Parse(itemm.SubItems[2].Text) + kolicina).ToString();
                        itemm.SubItems[3].Text = ukupnoC.ToString();

                        found = true;
                        break;
                    }

                }

                if (!found) {
                    string[] eto = { izabraniProizvod.getIme(), izabraniProizvod.getCena().ToString(), kolicina.ToString(), (cena * kolicina).ToString() };
                    ListViewItem item = new ListViewItem(eto);
                    test.Items.Add(item);
                }
                ukupno.Text = "UKUPNO: " + ukupnoC;
                UpdateStoCena(this.Text, ukupnoC.ToString());
                baza.updateProizvod(izabraniProizvod, (int)(kolicinaBroj));
            }
        }

        private void getKolicina()
        {
            formKolicina = new Form();

            formKolicina.FormBorderStyle = FormBorderStyle.None;

            Label text = new Label
            {
                Text = "Unesite količinu",
                Location = new Point(100, 20),
                Size = new Size(200, 20)
            };
            formKolicina.Controls.Add(text);

            kolicina = new TextBox { Location = new Point(90, 50) };
            formKolicina.Controls.Add(kolicina);

            Button confirmKolicinaButton = new Button
            {
                Text = "Potvrdi",
                Location = new Point(100, 100),
                Size = new Size(75, 30)
            };
            formKolicina.Controls.Add(confirmKolicinaButton);

            confirmKolicinaButton.Click += new System.EventHandler(confirmKolicinaButton_Click);

            Button cancelButton = new Button
            {
                Text = "Otkaži",
                Location = new Point(100, 150),
                Size = new Size(75, 30)
            };
            formKolicina.Controls.Add(cancelButton);

            cancelButton.Click += (senderr, ee) =>
            {
                kolicinaBroj = 0;
                formKolicina.Hide();
            };

            formKolicina.ShowDialog();
        }

        private void confirmKolicinaButton_Click(object sender, EventArgs e)
        {
            isNumeric = uint.TryParse(kolicina.Text, out kolicinaBroj);
            if (!isNumeric)
            {
                MessageBox.Show("Količina mora biti broj veci od 0");
                isNumeric = uint.TryParse(kolicina.Text, out kolicinaBroj);
            }
            formKolicina.Hide();
        }

        private void naplati_Click(object sender, EventArgs e)
        {
            naplata = new Form();

            naplata.FormBorderStyle = FormBorderStyle.None;

            iznos = new TextBox { Location = new Point(90, 50) };
            naplata.Controls.Add(iznos);

            Label text = new Label
            {
                Text = "Unesite iznos koji želite da platite",
                Location = new Point(70, 20),
                Size = new Size(200, 20)
            };
            naplata.Controls.Add(text);

            Button confirmNaplataButton = new Button
            {
                Text = "Naplati",
                Location = new Point(100, 100),
                Size = new Size(75, 30)
            };
            naplata.Controls.Add(confirmNaplataButton);

            Button cancelButton = new Button
            {
                Text = "Otkaži",
                Location = new Point(100, 150),
                Size = new Size(75, 30)
            };
            naplata.Controls.Add(cancelButton);

            cancelButton.Click += (senderr, ee) =>
            {

                naplata.Hide();
            };

            confirmNaplataButton.Click += new System.EventHandler(confirmNaplataButton_Click);
            if (!(ukupno.Text == "" || ukupno.Text == "UKUPNO: 0"))
            {
                naplata.ShowDialog();
            }

        }

        private void confirmNaplataButton_Click(object sender, EventArgs e) {
            double iznosBroj;
            bool isNumeric = double.TryParse(iznos.Text, out iznosBroj);
            if (!isNumeric || ukupnoC > iznosBroj)
            {
                MessageBox.Show("Moraš uneti ispravan izraz računa koji iznosi " + ukupnoC + "RSD");
                naplata.Show();
                isNumeric = double.TryParse(iznos.Text, out iznosBroj);
            }
            else
            {

                foreach (var item in test.Items)
                {
                    ListViewItem item1 = (ListViewItem)item;
                    string ime = item1.SubItems[0].Text;
                    uint kolicina = uint.Parse(item1.SubItems[2].Text);
                    baza.updatePazar(ime, (int)kolicina);
                }
                baza.updateKasa((int)ukupnoC);
                double kusur = iznosBroj - ukupnoC;
                MessageBox.Show("Uspesno ste platili račun\nKusur iznosi: " + Math.Round(kusur, 2) + "RSD");
                ukupnoC = 0;
                ukupno.Text = "UKUPNO: " + ukupnoC;
                UpdateStoCena(this.Text, String.Empty);
                test.Items.Clear();
                naplata.Hide();
            }
        }

        public ListView getRacun() {
            return this.test;
        }

        private void vrstaBtn_Click(object sender, EventArgs e)
        {
            if (proizvodiBtn.Count != 0) {
                foreach (Button btn in proizvodiBtn)
                {
                    this.Controls.Remove(btn);
                }
            }
            string imeVrste = (sender as Button).Text;
            List<Proizvod> proizvodi = new List<Proizvod>();
            foreach (Vrsta vrsta in vrste)
            {
                if (vrsta.getIme().Equals(imeVrste))
                {
                    proizvodi = baza.getProizvodiByVrsta(vrsta.getIdV());
                }
            }
            int i = 0;
            foreach (Proizvod p in proizvodi)
            {
                Button proizvodBtn = new Button
                {
                    Text = p.getIme(),
                    Location = new Point(461 + 100 * (i % 9), 81 + 30 * (i / 9)),
                    Size = new Size(100, 30),
                    BackColor = Color.White,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat
                };
                proizvodBtn.FlatAppearance.BorderSize = 0; 
                proizvodBtn.Click += item_Click;
                proizvodiBtn.Add(proizvodBtn);
                this.Controls.Add(proizvodBtn);
                i++;
            }
        }

        private void Test_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (test.SelectedItems.Count == 1)
            {
                item = test.SelectedItems[0];
                string imeProizvoda = item.SubItems[0].Text;
                string trenutnaKolicina = item.SubItems[2].Text;

                formIzmenaKolicine = new Form();

                formIzmenaKolicine.FormBorderStyle = FormBorderStyle.None;

                Label text = new Label
                {
                    Text = "Unesite novu količinu\n0 da obrišete",
                    Location = new Point(100, 20),
                    Size = new Size(200, 30)
                };
                formIzmenaKolicine.Controls.Add(text);

                novaKolicinaT = new TextBox { Location = new Point(90, 50) };
                formIzmenaKolicine.Controls.Add(novaKolicinaT);

                Button confirmKolicinaButton = new Button
                {
                    Text = "Potvrdi",
                    Location = new Point(100, 100),
                    Size = new Size(75, 30)
                };
                formIzmenaKolicine.Controls.Add(confirmKolicinaButton);

                confirmKolicinaButton.Click += new System.EventHandler(confirmNovaKolicinaButton_Click);

                Button cancelButton = new Button
                {
                    Text = "Otkaži",
                    Location = new Point(100, 150),
                    Size = new Size(75, 30)
                };
                formIzmenaKolicine.Controls.Add(cancelButton);

                cancelButton.Click += (senderr, ee) =>
                {
                    formIzmenaKolicine.Hide();
                };

                formIzmenaKolicine.ShowDialog();

            }
        }

        private void confirmNovaKolicinaButton_Click(object sender, EventArgs e) {
            if (uint.TryParse(novaKolicinaT.Text, out uint novaKolicina) && novaKolicina > 0)
            {

                Proizvod p = baza.getProizvodByName(item.SubItems[0].Text);
                baza.updateProizvod(p, (int)novaKolicina - int.Parse(item.SubItems[2].Text));

                item.SubItems[2].Text = novaKolicina.ToString();
                double cena = double.Parse(item.SubItems[1].Text);
                item.SubItems[3].Text = (cena * novaKolicina).ToString();

                double ukupnoC = 0;
                foreach (ListViewItem it in test.Items)
                {
                    ukupnoC += double.Parse(it.SubItems[3].Text);
                }
                this.ukupnoC = ukupnoC;

                ukupno.Text = "UKUPNO: " + ukupnoC;
                UpdateStoCena(this.Text, ukupnoC.ToString());
            }
            else if (novaKolicina == 0)
            {
                test.Items.Remove(item);
                ukupnoC -= double.Parse(item.SubItems[3].Text);
                ukupno.Text = "UKUPNO: " + ukupnoC;
                Proizvod p = baza.getProizvodByName(item.SubItems[0].Text);
                baza.updateProizvod(p, 0-int.Parse(item.SubItems[2].Text));
                if (ukupnoC == 0)
                {
                    UpdateStoCena(this.Text, String.Empty);
                }
                else
                {
                    UpdateStoCena(this.Text, ukupnoC.ToString());

                }
            }
            else
            {
                MessageBox.Show("Količina mora biti broj veći od 0.");
            }
            formIzmenaKolicine.Hide();
        }

        public void premesti(List<ListViewItem> items, PojedinacanSto sto) {
            foreach (ListViewItem item in items)
            {
                bool found = false;
                foreach (ListViewItem itemm in sto.test.Items)
                {
                    if (itemm.SubItems[0].Text.Equals(item.SubItems[0].Text))
                    {
                        itemm.SubItems[2].Text = (uint.Parse(itemm.SubItems[2].Text) + uint.Parse(item.SubItems[2].Text)).ToString();
                        itemm.SubItems[3].Text = (Double.Parse(itemm.SubItems[3].Text) + Double.Parse(item.SubItems[3].Text)).ToString();

                        found = true;
                        break;
                    }

                }

                if (!found)
                {
                    test.Items.Add(item);
                }
            }
        }

        private void buttonPomeri_Click(object sender, EventArgs e)
        {
            PojedinacanSto sto = parentForm.getPojedinacanStoByIme(comboBox1.Text);
            if(sto.sto.getIdS() != this.sto.getIdS())
            {
                List<ListViewItem> items = new List<ListViewItem>();
                foreach (ListViewItem item in test.Items)
                {
                    items.Add(item);
                }

                test.Items.Clear();
                UpdateStoCena(this.Text, String.Empty);
                sto.ukupnoC += ukupnoC;
                sto.ukupno.Text = "Ukupno: " + sto.ukupnoC;
                double novaCena = sto.ukupnoC;
                ukupno.Text = "UKUPNO: 0";
                sto.premesti(items, sto);
                UpdateStoCena(comboBox1.Text, novaCena.ToString());
                ukupnoC = 0;
            }
        }

    }
}
