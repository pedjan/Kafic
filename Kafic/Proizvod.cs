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
        private double cena;
        private int kolicina;

        public Proizvod() {
        }

        public void setId(int id) { 
            this.id = id;
        }

        public int getId() { 
            return this.id;
        }
        public void setIme(string ime) { 
            this.ime = ime;
        }
        public string getIme() { 
            return (this.ime);
        }

        public void setCena(double cena) { 
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
        public void setKolicina(int kolicina) { 
            this.kolicina = kolicina;
        }
    }
}
