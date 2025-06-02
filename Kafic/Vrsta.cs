using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafic
{
    internal class Vrsta
    {
        private int idV;
        private string ime;

        public Vrsta(int idV, string ime)
        {
            this.idV = idV;
            this.ime = ime;
        }

        public Vrsta()
        {

        }

        public int getIdV()
        {
            return this.idV;
        }
        public string getIme()
        {
            return this.ime;

        }

        public void setIdV(int idV)
        {
            this.idV = idV;
        }
        public void setIme(string ime)
        {
            this.ime = ime;
        }

    }
}
