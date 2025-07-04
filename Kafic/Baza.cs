﻿using System;
using System.Collections.Generic;


using System.Data.SQLite;

namespace Kafic
{
    internal class Baza
    {
        private string connstr = "Data Source=kafic.db;Version=3;";

        public Korisnik getKorisnik(string ime, string sifra) {
            Korisnik k = new Korisnik();

            using (SQLiteConnection conn = new SQLiteConnection(connstr))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand("select * from korisnik where ime = '" + ime + "' and sifra = '" + sifra + "'", conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            k.setId(reader.GetInt32(0));
                            k.setIme(reader.GetString(1));
                            k.setSifra(reader.GetString(2));
                        }
                        else
                        {
                            return null;
                        }
                        return k;
                    }
                }
            }
        }

        // Helper: get Vrsta by id using an existing connection
        private Vrsta getVrstaById(int id, SQLiteConnection conn)
        {
            Vrsta v = null;
            using (var cmd = new SQLiteCommand("select * from vrsta where idV = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        v = new Vrsta();
                        v.setIdV(reader.GetInt32(0));
                        v.setIme(reader.GetString(1));
                    }
                }
            }
            return v;
        }

        public Proizvod getProizvodByName(string ime)
        {
            Proizvod p = null;
            using (var conn = new SQLiteConnection(connstr))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("select * from proizvodi where ime = @ime", conn))
                {
                    cmd.Parameters.AddWithValue("@ime", ime);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            p = new Proizvod();
                            p.setId(reader.GetInt32(0));
                            p.setIme(reader.GetString(1));
                            p.setIdV(getVrstaById(reader.GetInt32(2), conn));
                            p.setCena(reader.GetDouble(3));
                            p.setKolicina(reader.GetInt32(4));
                        }
                    }
                }
            }
            return p;
        }

        public void updateProizvod(Proizvod p, int kolicina) 
        {
            int novaKolicina = (p.getKolicina() - kolicina);
            string ime = p.getIme();

            using (SQLiteConnection conn = new SQLiteConnection(connstr))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand("update proizvodi set kolicina = '" + novaKolicina + "' where ime = '" + ime + "'", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void kolicinaProizvoda(String ime, uint kolicina) {
            using (SQLiteConnection conn = new SQLiteConnection(connstr))
            {   
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand("update proizvodi set kolicina = '" + kolicina + "' where ime = '" + ime + "'", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void dodajKolicinuZaProizvod(Proizvod p, uint kolicina)
        {
            string ime = p.getIme();
            uint novaKolicina = (uint)p.getKolicina() + kolicina;
            using(SQLiteConnection conn = new SQLiteConnection(connstr)) {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand("update proizvodi set kolicina = '" + novaKolicina + "' where ime = '" + ime + "'", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void updateSto(string ime, int x, int y)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connstr))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand("update sto set x = '" + x + "', y = '" + y + "' where ime = '" + ime + "'", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Sto> getSveStolove()
        {
            List<Sto> stolovi = new List<Sto>();

            using (SQLiteConnection conn = new SQLiteConnection(connstr))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand("select * from Sto", conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Sto sto = new Sto(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4));
                            stolovi.Add(sto);
                        }
                        return stolovi;
                    }
                }
            }
        }

        public void dodajSto(int idS, string ime, int X, int Y, int mesto)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connstr))
            {
                conn.Open();

                using(SQLiteCommand cmd = new SQLiteCommand("insert into Sto (idS, ime, x, y, mesto) values (@idS, @ime, @X, @Y, @mesto)", conn)) {
                    cmd.Parameters.AddWithValue("@idS", idS);
                    cmd.Parameters.AddWithValue("@ime", ime);
                    cmd.Parameters.AddWithValue("@X", X);
                    cmd.Parameters.AddWithValue("@Y", Y);
                    cmd.Parameters.AddWithValue("@mesto", mesto);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void obrisiSto(string ime) {
            using (SQLiteConnection conn = new SQLiteConnection(connstr))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("delete from Sto where ime = @ime", conn))
                {
                    cmd.Parameters.AddWithValue("@ime", ime);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int getBrStolova() {
            int broj = 0;
            using (SQLiteConnection conn = new SQLiteConnection(connstr))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM sto", conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            broj = reader.GetInt32(0);
                        }
                    }
                    return broj;
                }
            }
        }

        public List<Vrsta> getVrste() {
            List<Vrsta> vrste = new List<Vrsta>();

            using (SQLiteConnection conn = new SQLiteConnection(connstr))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand("select * from vrsta", conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Vrsta vrsta = new Vrsta(reader.GetInt32(0), reader.GetString(1));
                            vrste.Add(vrsta);
                        }
                    }
                    return vrste;
                }
            }
        }

        public List<Proizvod> getProizvodiByVrsta(int idV)
        {
            var proizvodi = new List<Proizvod>();
            using (var conn = new SQLiteConnection(connstr))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("select * from proizvodi where idV = @idV", conn))
                {
                    cmd.Parameters.AddWithValue("@idV", idV);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var proizvod = new Proizvod(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                getVrstaById(idV, conn),
                                reader.GetDouble(3),
                                reader.GetInt32(4)
                            );
                            proizvodi.Add(proizvod);
                        }
                    }
                }
            }
            return proizvodi;
        }

        public Vrsta getVrstaById(int id)
        {
            Vrsta v = new Vrsta();
            using (SQLiteConnection conn = new SQLiteConnection(connstr))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("select * from vrsta where idV = '" + id + "'", conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            v.setIdV(reader.GetInt32(0));
                            v.setIme(reader.GetString(1));
                        }
                        else
                        {
                            return null;
                        }
                    }
                    return v;
                }
            }
        }

        public List<Proizvod> getSveProizvode()
        {
            var proizvodi = new List<Proizvod>();
            using (var conn = new SQLiteConnection(connstr))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("select * from proizvodi", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var proizvod = new Proizvod(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                getVrstaById(reader.GetInt32(2), conn),
                                reader.GetDouble(3),
                                reader.GetInt32(4)
                            );
                            proizvodi.Add(proizvod);
                        }
                    }
                }
            }
            return proizvodi;
        }

        public int getKasa() {
            int kasa = 0;
            using (SQLiteConnection conn = new SQLiteConnection(connstr))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("select * from kasa", conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kasa = reader.GetInt32(1);
                        }
                    }
                    return kasa;
                }
            }
        }

        public void updateKasa(int izmena)
        {
            int novoStanje = getKasa() + izmena;

            using (SQLiteConnection conn = new SQLiteConnection(connstr))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand("update kasa set stanje = '" + novoStanje + "'", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Pazar> getPazar(DateTime datumm) {
            string datum = datumm.ToString().Substring(0, 10);
            List<Pazar> pazari = new List<Pazar>();

            using (SQLiteConnection conn = new SQLiteConnection(connstr))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("select * from pazar where datum = '" + datum + "'", conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pazar pazar = new Pazar(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3));
                            pazari.Add(pazar);
                        }
                    }
                    return pazari;
                }
            }
        }

        public Pazar getProizvodUPazaru(string proizvod) {
            DateTime datumm = DateTime.Now.Date;
            string datum = datumm.ToString().Substring(0, 10);
            Pazar p = null;
            using (SQLiteConnection conn = new SQLiteConnection(connstr))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("select * from pazar where proizvod = '" + proizvod + "' and datum = '" + datum + "'", conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            p = new Pazar(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3));
                            return p;
                        }
                    }
                    return p;
                }
            }
        }

        public void updatePazar(string proizvod, int kolicina) {
            DateTime datumm = DateTime.Now.Date;
            string datum = datumm.ToString().Substring(0, 10);
            Pazar pazar = getProizvodUPazaru(proizvod);
            using (SQLiteConnection conn = new SQLiteConnection(connstr))
            {
                conn.Open();
                if (pazar != null)
                {
                    kolicina += pazar.Kolicina;
                    using (SQLiteCommand cmd = new SQLiteCommand("update pazar set kolicina = '" + kolicina + "' where proizvod = '" + proizvod + "' and datum = '" + datum + "'", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (SQLiteCommand cmd = new SQLiteCommand("insert into pazar (proizvod, kolicina, datum) values (@proizvod, @kolicina, @datum)", conn))
                    {
                        cmd.Parameters.AddWithValue("@proizvod", proizvod);
                        cmd.Parameters.AddWithValue("@kolicina", kolicina);
                        cmd.Parameters.AddWithValue("@datum", datum);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
