using System;
using System.CodeDom;
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
    public partial class Pocetna : Form
    {
        Login parentForm;
        UpravljanjeProizvodima up;
        Baza baza = new Baza();
        

        private int BROJ_STOLOVA;

        List<PojedinacanSto> listaPojedinacnihStolova = new List<PojedinacanSto>();
        List<Sto> listaStolova;

        

        bool admin = true;

        bool dragging;
        int xoffset;
        int yoffset;

        public Pocetna(Login parent)
        {
            InitializeComponent();
            dragging = false;


            BROJ_STOLOVA = baza.getBrStolova();
            listaStolova = baza.getSveStolove();

            foreach (Sto stoo in listaStolova)
            {
                Sto sto = new Sto(stoo.getIme(), stoo.getX(), stoo.getY(), this);
                PojedinacanSto pojSto = new PojedinacanSto(sto, this);
                listaPojedinacnihStolova.Add(pojSto);
            }
            this.parentForm = parent;
            if (!admin) 
            {
                uprproj.Visible = false;
            }
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
            foreach (PojedinacanSto sto in listaPojedinacnihStolova) { 
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
            if (Control.ModifierKeys == Keys.Control)
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
    }
}
