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

        private readonly int BROJ_STOLOVA = 4;

        List<PojedinacanSto> listaPojedinacnihStolova = new List<PojedinacanSto>();
        List<Sto> listaStolova = new List<Sto>();

        bool admin = true;

        public Pocetna(Login parent)
        {
            InitializeComponent();

            for (int i = 0; i < BROJ_STOLOVA; i++)
            {
                Sto sto = new Sto("sto" + (i + 1));
                listaStolova.Add(sto);
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
            if (ime.Equals("sto1"))
            {
                return sto1;
            }
            if (ime.Equals("sto2"))
            {
                return sto2;
            }
            if (ime.Equals("sto3"))
            {
                return sto3;
            }
            if (ime.Equals("sto4"))
            {
                return sto4;
            }
            return null;
        }

        private void odjavi_se_Click(object sender, EventArgs e)
        {
            if (sto1.Text == String.Empty && sto2.Text == String.Empty && sto3.Text == String.Empty && sto4.Text == String.Empty)
            {
                parentForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Niste naplatili sve racune!");
            }
        }

        private void sto_Click(object sender, EventArgs e)
        {
            string ime = (sender as Button).Name;

            for(int i = 0; i < BROJ_STOLOVA; i++)
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
    }
}
