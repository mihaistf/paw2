using System;

namespace ProiectPartea1
{
    class Aparate
    {
        private string denumire;
        private int nrAparate;

        public string Denumire { get => denumire; set => denumire = value; }
        public int NrAparate { get => nrAparate; set => nrAparate = value; }

        public Aparate(string denumire, int nrAparate)
        {
            this.denumire = denumire;
            this.nrAparate = nrAparate;
        }
        public Aparate()
        {
            denumire = "sunt multe aparate";
            nrAparate = 2;
        }

        public override string ToString()
        {
            return "Aparatul are descrierea: " + denumire + ", iar numarul aparatelor este de: " + nrAparate;
        }
    }
}
