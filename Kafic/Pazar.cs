using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kafic
{
    internal class Pazar
    {
        private int id;
        private string proizvod;
        private int kolicina;
        private DateTime datum;

        public Pazar(int id, string proizvod, int kolicina, DateTime datum)
        {
            this.id = id;
            this.proizvod = proizvod;
            this.kolicina = kolicina;
            this.datum = datum;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Proizvod
        {
            get { return proizvod; }
            set { proizvod = value; }
        }
        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }
        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }
    }
}
