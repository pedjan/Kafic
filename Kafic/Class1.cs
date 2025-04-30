using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafic
{
    internal class Korisnik
    {
        private string ime;
        private string sifra;
        public Korisnik(string ime, string sifra) { 
            this.ime = ime;
            this.sifra = sifra;
        }

        public string getIme() { 
            return ime;
        }

        public string getSifra()
        {
            return sifra;
        }
    }
}
