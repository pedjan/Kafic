using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafic
{
    internal class Proizvod
    {
        private int id;
        private string ime;
        private Vrsta vrsta;
        private double cena;
        private int kolicina;

        public Proizvod()
        {
        }

        public Proizvod(int id, string ime, Vrsta vrsta, double cena, int kolicina)
        {
            this.id = id;
            this.ime = ime;
            this.vrsta = vrsta;
            this.cena = cena;
            this.kolicina = kolicina;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }

        public void setIme(string ime)
        {
            this.ime = ime;
        }

        public string getIme()
        {
            return (this.ime);
        }

        public void setCena(double cena)
        {
            this.cena = cena;
        }

        public double getCena()
        {
            return this.cena;
        }

        public int getKolicina()
        {
            return this.kolicina;
        }

        public void setKolicina(int kolicina)
        {
            this.kolicina = kolicina;
        }

        public void setIdV(Vrsta vrsta)
        {
            this.vrsta = vrsta;
        }

        public string getVrstaIme()
        {
            return this.vrsta.getIme();
        }
    }
}
