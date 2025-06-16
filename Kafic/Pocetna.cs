using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kafic
{
    public partial class Pocetna : Form
    {
        Login parentForm;
        UpravljanjeProizvodima up;
        Baza baza = new Baza();

        private int BROJ_STOLOVA;
        List<PojedinacanSto> listaPojedinacnihStolova = new List<PojedinacanSto>();
        List<Sto> listaStolova;
        public int mesto = 0;

        bool brisanjeStola = false;

        //pomeranje stolova
        bool dragging;
        int xoffset;
        int yoffset;
        bool pomeranje;


        public Pocetna(Login parent)
        {
            InitializeComponent();
            dragging = false;

            ucitajStolove();

            this.parentForm = parent;

            up = new UpravljanjeProizvodima(this);
        }

        private void ucitajStolove()
        {
            BROJ_STOLOVA = baza.getBrStolova();
            listaStolova = baza.getSveStolove();

            foreach (Sto stoo in listaStolova)
            {
                Sto sto = new Sto(stoo.getIdS(), stoo.getIme(), stoo.getX(), stoo.getY(), stoo.getMesto(), this);
                PojedinacanSto pojSto = new PojedinacanSto(sto, this);
                listaPojedinacnihStolova.Add(pojSto);
                if (sto.getMesto() != 0)
                {
                    sto.stoBtn.Visible = false;
                }
            }
        }

        public Button GetStoByName(string ime)
        {
            foreach (PojedinacanSto sto in listaPojedinacnihStolova)
            {
                if (sto.sto.getIme().Equals(ime))
                {
                    return sto.sto.stoBtn;
                }
            }
            return null;
        }

        private void odjavi_se_Click(object sender, EventArgs e)
        {
            foreach (PojedinacanSto sto in listaPojedinacnihStolova)
            {
                if (sto.getRacun().Items.Count > 0)
                {
                    MessageBox.Show("Niste naplatili sve račune!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            List<Pazar> pazar = baza.getPazar(DateTime.Now);
            int kolicina = 0;
            foreach (Pazar p in pazar)
            {
                kolicina += p.Kolicina * (int)baza.getProizvodByName(p.Proizvod).getCena();
            }
            MessageBox.Show("Pazar iznosi: " + kolicina + "RSD", "Pazar za danas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            parentForm.Show();
            this.Hide();
        }

        public void sto_Click(object sender, EventArgs e)
        {
            string ime = (sender as Button).Name;

            for (int i = 0; i < BROJ_STOLOVA; i++)
            {
                if (ime.Equals(listaStolova[i].getIme()))
                {
                    listaPojedinacnihStolova[i].Show();
                    this.Hide();
                }
            }

        }

        private void uprproj_Click(object sender, EventArgs e)
        {
            up.Show();
            this.Hide();
        }

        public void sto_MouseDown(object sender, MouseEventArgs e)
        {
            Button b;
            b = (Button)sender;
            if (pomeranje)
            {

                dragging = true;
                xoffset = e.X;
                yoffset = e.Y;

            }
        }

        public void sto_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        public void sto_MouseMove(object sender, MouseEventArgs e)
        {
            Button b;
            int XMoved;
            int YMoved;
            int newBtnX;
            int newBtnY;

            b = (Button)sender;
            if (dragging)
            {
                XMoved = e.Location.X - xoffset;
                YMoved = e.Location.Y - yoffset;

                newBtnX = b.Location.X + XMoved;
                newBtnY = b.Location.Y + YMoved;

                //X
                if (newBtnX <= 0)
                {
                    newBtnX = b.Location.X;
                }
                else if (newBtnX + b.Height >= this.ClientSize.Width)
                {
                    newBtnX = b.Location.X;
                }

                //Y
                if (newBtnY <= 100)
                {
                    newBtnY = b.Location.Y;
                }
                else if (newBtnY + b.Height >= this.ClientSize.Height)
                {
                    newBtnY = b.Location.Y;
                }
                b.Location = new Point(newBtnX, newBtnY);
            }
        }

        private void updateStolove()
        {
            foreach (PojedinacanSto sto in listaPojedinacnihStolova)
            {
                baza.updateSto(sto.sto.getIme(), sto.sto.stoBtn.Location.X, sto.sto.stoBtn.Location.Y);
            }
        }

        private void napraviSto_Click(object sender, EventArgs e)
        {

            BROJ_STOLOVA++;
            bool napravio = false;
            for (int i = 0; i < listaStolova.Count; i++)
            {
                    int pom = i + 1;
                    if (listaStolova[i].getIdS() != pom)
                    {
                        Sto sto = new Sto(pom, "Sto " + pom, 100, 100, mesto, this);
                        listaStolova.Add(sto);
                        PojedinacanSto pojSto = new PojedinacanSto(sto, this);
                        listaPojedinacnihStolova.Add(pojSto);
                        baza.dodajSto(sto.getIdS(), sto.getIme(), sto.getX(), sto.getY(), sto.getMesto());
                        listaStolova = baza.getSveStolove();
                        napravio = true;
                    }
                
            }

            if (!napravio) {
                Sto sto = new Sto(BROJ_STOLOVA, "Sto " + BROJ_STOLOVA, 100, 100, mesto, this);
                listaStolova.Add(sto);
                PojedinacanSto pojSto = new PojedinacanSto(sto, this);
                listaPojedinacnihStolova.Add(pojSto);
                baza.dodajSto(sto.getIdS(), sto.getIme(), sto.getX(), sto.getY(), sto.getMesto());
            }
            
        }

        private void obrisiSto_Click(object sender, EventArgs e)
        {
            brisanjeStola = !brisanjeStola;
            if (brisanjeStola)
            {
                odjavi_se.Visible = false;
                napraviSto.Visible = false;
                uprproj.Visible = false;
                buttonPomeriSto.Visible = false;

                obrisiSto.Text = "Zaustavi";

                foreach (PojedinacanSto sto in listaPojedinacnihStolova)
                {
                    sto.sto.stoBtn.Click -= new System.EventHandler(sto_Click);
                    sto.sto.stoBtn.Click += new System.EventHandler(obrisi);
                }
            }
            else
            {
                odjavi_se.Visible = true;
                napraviSto.Visible = true;
                uprproj.Visible = true;
                buttonPomeriSto.Visible = true;

                obrisiSto.Text = "Obrisi";

                foreach (PojedinacanSto sto in listaPojedinacnihStolova)
                {
                    sto.sto.stoBtn.Click -= new System.EventHandler(obrisi);
                    sto.sto.stoBtn.Click += new System.EventHandler(sto_Click);
                }
            }

        }

        private void obrisi(object sender, EventArgs e)
        {
            if (brisanjeStola)
            {
                Button b = (Button)sender;
                string ime = b.Name;
                for (int i = 0; i < BROJ_STOLOVA; i++)
                {
                    if (ime.Equals(listaStolova[i].getIme()))
                    {
                        if (listaPojedinacnihStolova[i].getRacun().Items.Count > 0)
                        {
                            MessageBox.Show("Ne možeš obrisati sto koji ima račune!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            baza.obrisiSto(listaStolova[i].getIme());
                            listaStolova.RemoveAt(i);
                            listaPojedinacnihStolova.RemoveAt(i);
                            b.Dispose();
                            BROJ_STOLOVA--;
                            break;
                        }
                    }
                }
            }
        }

        public void setKorisnik(Korisnik k)
        {
            if (!(k.getIme().Equals("admin") && k.getSifra().Equals("admin")))
            {
                uprproj.Visible = false;
                napraviSto.Visible = false;
                obrisiSto.Visible = false;
                buttonPomeriSto.Visible = false;
            }
            else
            {
                uprproj.Visible = true;
                napraviSto.Visible = true;
                obrisiSto.Visible = true;
                buttonPomeriSto.Visible = true;
            }
            korisnikLabel.Text = "Prijavljen si kao: " + k.getIme();

            System.Windows.Forms.Timer aTimer = new System.Windows.Forms.Timer();
            aTimer.Tick += new EventHandler(OnTimedEvent);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;

        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    datumIVreme.Text = "Datum i vreme: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                });
            }
            catch (ObjectDisposedException)
            {
                // Ignore exception if the form is closed
            }
        }

        private void buttonPomeriSto_Click(object sender, EventArgs e)
        {
            updateStolove();
            pomeranje = !pomeranje;
            if (pomeranje)
            {
                odjavi_se.Visible = false;
                napraviSto.Visible = false;
                uprproj.Visible = false;
                obrisiSto.Visible = false;

                buttonPomeriSto.Text = "Zaustavi";
                foreach (PojedinacanSto sto in listaPojedinacnihStolova)
                {
                    sto.sto.stoBtn.Click -= new System.EventHandler(sto_Click);
                }

            }
            else
            {
                odjavi_se.Visible = true;
                napraviSto.Visible = true;
                uprproj.Visible = true;
                obrisiSto.Visible = true;

                buttonPomeriSto.Text = "Pomeri sto";
                foreach (PojedinacanSto sto in listaPojedinacnihStolova)
                {
                    sto.sto.stoBtn.Click += new System.EventHandler(sto_Click);
                }
            }
        }

        private void mesto_Click(object sender, EventArgs e)
        {
            string imeDugmeta = (sender as Button).Name;

            if (imeDugmeta.Equals("buttonSplav"))
            {
                mesto = 0;
                labelMesto.Text = "Splav";
                this.BackgroundImage = Properties.Resources.splav;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                foreach (PojedinacanSto sto in listaPojedinacnihStolova)
                {
                    if (sto.sto.getMesto() == 0)
                    {
                        sto.sto.stoBtn.Visible = true;
                    }
                    else
                    {
                        sto.sto.stoBtn.Visible = false;
                    }
                }
                mesto = 0;
            }
            else if (imeDugmeta.Equals("buttonPlaza"))
            {
                mesto = 1;
                labelMesto.Text = "Plaža";
                this.BackgroundImage = Properties.Resources.plaza;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                foreach (PojedinacanSto sto in listaPojedinacnihStolova)
                {
                    if (sto.sto.getMesto() == 1)
                    {
                        sto.sto.stoBtn.Visible = true;
                    }
                    else
                    {
                        sto.sto.stoBtn.Visible = false;
                    }
                }

            }
            else if (imeDugmeta.Equals("buttonKafic"))
            {
                mesto = 2;
                labelMesto.Text = "Kafić";
                this.BackgroundImage = Properties.Resources.pod;
                this.BackgroundImageLayout = ImageLayout.Tile;
                foreach (PojedinacanSto sto in listaPojedinacnihStolova)
                {
                    if (sto.sto.getMesto() == 2)
                    {
                        sto.sto.stoBtn.Visible = true;
                    }
                    else
                    {
                        sto.sto.stoBtn.Visible = false;
                    }
                }

            }
        }

        public PojedinacanSto getPojedinacanStoByIme(string ime)
        {
            foreach (PojedinacanSto sto in listaPojedinacnihStolova)
            {
                if (sto.sto.getIme().Equals(ime))
                {
                    return sto;
                }
            }
            return null;
        }
    }
}
