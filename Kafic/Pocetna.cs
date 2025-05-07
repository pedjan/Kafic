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
    public partial class Pocetna : Form
    {
        PojedinacanSto pojsto1;
        PojedinacanSto pojsto2;
        PojedinacanSto pojsto3;
        PojedinacanSto pojsto4;
        Sto stoo1 = new Sto("sto1");
        Sto stoo2 = new Sto("sto2");
        Sto stoo3 = new Sto("sto3");
        Sto stoo4 = new Sto("sto4");

        public Pocetna()
        {
            InitializeComponent();
            pojsto1 = new PojedinacanSto(stoo1, this);
            pojsto2 = new PojedinacanSto(stoo2, this);
            pojsto3 = new PojedinacanSto(stoo3, this);
            pojsto4 = new PojedinacanSto(stoo4, this);
        }
        public Button getStoByName(string ime)
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
            this.Hide();
        }

        private void sto_Click(object sender, EventArgs e)
        {
            string ime = (sender as Button).Name;
            if (ime.Equals(stoo1.getIme()))
            {
                pojsto1.Show();
            }
            if (ime.Equals(stoo2.getIme()))
            {
                pojsto2.Show();
            }
            if (ime.Equals(stoo3.getIme()))
            {
                pojsto3.Show();
            }
            if (ime.Equals(stoo4.getIme()))
            {
                pojsto4.Show();
            }

        }
    }
}
