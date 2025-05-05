using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafic
{
    public class Sto
    {
        private string ime;
        private List<Porudzbina> porudzbine;
        private bool slobodan;

        public Sto(string ime) { 
            this.ime = ime;
            porudzbine = new List<Porudzbina>();
            slobodan = true;
        }

        public string getIme() { 
            return this.ime;
        }
    }
}
