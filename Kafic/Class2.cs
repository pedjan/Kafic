using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                return null;
            }
                return k;
        }
    }

}
