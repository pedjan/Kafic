

namespace Kafic
{
    internal class Pazar
    {
        private int id;
        private string proizvod;
        private int kolicina;
        private string datum;

        public Pazar(int id, string proizvod, int kolicina, string datum)
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
        public string Datum
        {
            get { return datum; }
            set { datum = value; }
        }
    }
}
