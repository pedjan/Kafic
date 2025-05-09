using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Kafic
{
    internal class Baza
    {

        public Korisnik getKorisnik(string ime, string sifra) {
            Korisnik k = new Korisnik();

            string connstr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Kafic; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from korisnik where ime = '" + ime + "' and sifra = '" + sifra + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                k.setIme(ime);
                k.setSifra(sifra);
            }
            else
            {
                conn.Close();
                return null;
            }
            conn.Close();
            return k;
        }

        public Proizvod getProizvodByName(string ime) { 
            Proizvod p = new Proizvod();

            string connstr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Kafic; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from proizvodi where ime = '" + ime + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                p.setId(reader.GetInt32(0));
                p.setIme(reader.GetString(1));
                p.setCena(reader.GetDouble(2));
                p.setKolicina(reader.GetInt32(3));
            }
            else
            {
                conn.Close();
                return null;
            }
            conn.Close();
            return p;
        }

        public void updateProizvod(String ime, uint kolicina) 
        {
            Proizvod p = getProizvodByName(ime);
            uint novaKolicina = (uint)p.getKolicina() - kolicina;

            string connstr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Kafic; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("update proizvodi set kolicina = '" + novaKolicina + "' where ime = '" + ime + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }
    }

}
