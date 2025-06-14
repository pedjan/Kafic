﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Kafic
{
    public partial class Login : Form
    {
        Pocetna pocetna;
        Baza baza = new Baza();

        public Login()
        {
            InitializeComponent();
            pocetna = new Pocetna(this);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ugasi_program_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prijavi_se_Click(object sender, EventArgs e)
        {
            Korisnik k = baza.getKorisnik(Ime.Text, Sifra.Text);

            if (k != null)
            {
                Ime.Text = null;
                Sifra.Text = null;
                pocetna.Show(this);
                pocetna.setKorisnik(k);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Podaci za prijacu nisu validni!");
            }
        }

    }

}
