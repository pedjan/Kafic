using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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


            BROJ_STOLOVA = baza.getBrStolova();
            listaStolova = baza.getSveStolove();

            foreach (Sto stoo in listaStolova)
            {
                Sto sto = new Sto(stoo.getIdS(), stoo.getIme(), stoo.getX(), stoo.getY(), this);
                PojedinacanSto pojSto = new PojedinacanSto(sto, this);
                listaPojedinacnihStolova.Add(pojSto);
            }
            this.parentForm = parent;

            up = new UpravljanjeProizvodima(this);
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
                    MessageBox.Show("Niste naplatili sve račune!");
                    return;
                }
            }
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
                if (newBtnY <= 0)
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

        private void updateSto_Click(object sender, EventArgs e)
        {
            foreach (PojedinacanSto sto in listaPojedinacnihStolova)
            {
                baza.updateSto(sto.sto.getIme(), sto.sto.stoBtn.Location.X, sto.sto.stoBtn.Location.Y);
            }
        }

        private void napraviSto_Click(object sender, EventArgs e)
        {
            BROJ_STOLOVA++;
            Sto sto = new Sto(BROJ_STOLOVA+1, "Sto " + BROJ_STOLOVA, 100, 100, this);
            listaStolova.Add(sto);
            PojedinacanSto pojSto = new PojedinacanSto(sto, this);
            listaPojedinacnihStolova.Add(pojSto);
            baza.dodajSto(sto.getIme(), sto.getX(), sto.getY());
        }

        private void obrisiSto_Click(object sender, EventArgs e)
        {
            brisanjeStola = !brisanjeStola;
            if (brisanjeStola)
            {
                odjavi_se.Visible = false;
                updateSto.Visible = false;
                napraviSto.Visible = false;
                uprproj.Visible = false;

                foreach (PojedinacanSto sto in listaPojedinacnihStolova)
                {
                    sto.sto.stoBtn.Click -= new System.EventHandler(sto_Click);
                    sto.sto.stoBtn.Click += new System.EventHandler(obrisi);
                }
            }
            else
            {
                odjavi_se.Visible = true;
                updateSto.Visible = true;
                napraviSto.Visible = true;
                uprproj.Visible = true;

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

        public void setKorisnik(Korisnik k) {
            if (!(k.getIme().Equals("admin") && k.getSifra().Equals("admin"))) {
                uprproj.Visible = false;
                napraviSto.Visible = false;
                updateSto.Visible = false;
                obrisiSto.Visible = false;
                buttonPomeriSto.Visible = false;
            }
            else
            {
                uprproj.Visible = true;
                napraviSto.Visible = true;
                updateSto.Visible = true;
                obrisiSto.Visible = true;
                buttonPomeriSto.Visible = true;
            }
            korisnikLabel.Text = "Prijavljen si kao: " + k.getIme();


            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;
            
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                datumIVreme.Text = "Datum i vreme: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            });
        }

        private void buttonPomeriSto_Click(object sender, EventArgs e)
        {
            pomeranje = !pomeranje;
            if (pomeranje)
            {
                buttonPomeriSto.Text = "Zaustavi";
                foreach (PojedinacanSto sto in listaPojedinacnihStolova)
                {
                    sto.sto.stoBtn.Click -= new System.EventHandler(sto_Click);
                }

            }
            else {
                buttonPomeriSto.Text = "Pomeri sto";
                foreach (PojedinacanSto sto in listaPojedinacnihStolova)
                {
                    sto.sto.stoBtn.Click += new System.EventHandler(sto_Click);
                }
            }
        }
    }
}
