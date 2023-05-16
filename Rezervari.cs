using System;

namespace ProiectPartea1
{
    class Rezervari : Aparate
    {
        private DateTime dtRezervari;

        public DateTime DtRezervari
        {
            get { return dtRezervari; }
            set { dtRezervari = value; }
        }

        public override string ToString()
        {
            return dtRezervari.ToString() + " " + base.ToString();
        }
    }
}