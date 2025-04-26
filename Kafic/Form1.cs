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
    public partial class Login : Form
    {
        static bool prijavljen = false;
        Pocetna pocetna = new Pocetna();

        Korisnik k = new Korisnik("Admin", "admin");

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ugasi_program_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void odjavljen(bool a) {
            prijavljen = a;
        }

        private void prijavi_se_Click(object sender, EventArgs e)
        {
            if (!prijavljen && Ime.Text.Equals(k.getIme()) && Sifra.Text.Equals(k.getSifra()))
            {
                prijavljen = true;
                pocetna.Show();
            }
        }
    }
}
