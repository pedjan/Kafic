using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafic
{
    public partial class Login : Form
    {
        Pocetna pocetna = new Pocetna();

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


        private void prijavi_se_Click(object sender, EventArgs e)
        {
            Korisnik k = new Korisnik(Ime.Text, Sifra.Text);

            string connstr = "Data Source = DESKTOP-QU4VIAR\\SQLEXPRESS; Initial Catalog = Kafic; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from korisnik where ime = '"+ k.getIme() +"' and sifra = '"+k.getSifra()+"'", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                pocetna.Show();
            }
            else
            {
                MessageBox.Show("Podaci za prijacu nisu validni!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source = DESKTOP-QU4VIAR\\SQLEXPRESS; Initial Catalog = Kafic; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from korisnik where ime = 'Admin'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string output = " " + reader.GetValue(1);
            MessageBox.Show(output);
            while (reader.Read())
            {
                //string output = "Output = " + reader.GetValue(0) + " " + reader.GetValue(1) + " " + reader.GetValue(2);
                
            }
        }
    }
}
