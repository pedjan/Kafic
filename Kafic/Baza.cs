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

            string connstr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = baza; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from korisnik where ime = '" + ime + "' and sifra = '" + sifra + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                k.setId(reader.GetInt32(0));
                k.setIme(reader.GetString(1));
                k.setSifra(reader.GetString(2));
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

            string connstr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = baza; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from proizvodi where ime = '" + ime + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                p.setId(reader.GetInt32(0));
                p.setIme(reader.GetString(1));
                p.setIdV(this.getVrstaById(reader.GetInt32(2)));
                p.setCena(reader.GetDouble(3));
                p.setKolicina(reader.GetInt32(4));
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

            string connstr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = baza; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("update proizvodi set kolicina = '" + novaKolicina + "' where ime = '" + ime + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }

        public void updateSto(string ime, int x, int y)
        {

            string connstr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = baza; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("update sto set x = '" + x + "', y = '" + y + "' where ime = '" + ime + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }

        public List<Sto> getSveStolove()
        {
            List<Sto> stolovi = new List<Sto>();

            string connstr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = baza; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from Sto", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Sto sto = new Sto(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                stolovi.Add(sto);
            }
            conn.Close();
            return stolovi;
        }

        public void dodajSto(string ime, int X, int Y) {
            string connstr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = baza; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Sto (ime, x, y) values (@ime, @X, @Y)", conn);
            cmd.Parameters.AddWithValue("@ime", ime);
            cmd.Parameters.AddWithValue("@X", X);
            cmd.Parameters.AddWithValue("@Y", Y);
            cmd.ExecuteNonQuery();


            conn.Close();
        }

        public void obrisiSto(string ime) {
            string connstr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = baza; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Sto where ime = @ime", conn);
            cmd.Parameters.AddWithValue("@ime", ime);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public int getBrStolova() {
            int broj = 0;
            string connstr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = baza; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM sto ", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                broj = reader.GetInt32(0);
            }
            conn.Close();
            return broj;
        }

        public List<Vrsta> getVrste() {
            List<Vrsta> vrste = new List<Vrsta>();

            string connstr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = baza; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from vrsta", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Vrsta vrsta = new Vrsta(reader.GetInt32(0), reader.GetString(1));
                vrste.Add(vrsta);
            }
            conn.Close();
            return vrste;
        }

        public List<Proizvod> getProizvodiByVrsta(Vrsta v)
        {
            List<Proizvod> proizvodi = new List<Proizvod>();

            string connstr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = baza; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from proizvodi where idV = '"+ v.getIdV() + "' ", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Proizvod proizvod = new Proizvod(reader.GetInt32(0), reader.GetString(1), v, reader.GetDouble(3), reader.GetInt32(4));
                proizvodi.Add(proizvod);
            }
            conn.Close();

            return proizvodi;


        }

        public Vrsta getVrstaById(int id)
        {
            Vrsta v = new Vrsta();
            string connstr = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = baza; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from vrsta where idV = '" + id + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                v.setIdV(reader.GetInt32(0));
                v.setIme(reader.GetString(1));
            }
            else
            {
                conn.Close();
                return null;
            }
            conn.Close();
            return v;
        }
    }

}
