using System;

namespace ProiectPartea1
{
    class Clienti : Rezervari, ICloneable
    {
        public string nume;
        public string prenume;
        public string telefon;
        public string adresa;
        public string email;
        public DateTime dtRez;

        // Constructor implicit
        public Clienti()
        {
        }

        public Clienti(string nume, string prenume, DateTime dtRez, string telefon, string adresa, string email)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.telefon = telefon;
            this.adresa = adresa;
            this.email = email;
            this.dtRez = dtRez;
        }

        public Clienti(string nume, string prenume, string telefon, string adresa, string email, DateTime dtRez)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.telefon = telefon;
            this.adresa = adresa;
            this.email = email;
            this.dtRez = dtRez;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }

        public DateTime DataRezervare
        {
            get { return dtRez; }
            set { dtRez = value; }
        }

        public bool CompareTo(object obj)
        {
            if (obj is Clienti c)
            {
                return string.Compare(this.nume, c.nume) == 0 && string.Compare(this.prenume, c.prenume) == 0;
            }
            return false;
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

        public Clienti Clone()
        {
            return (Clienti)((ICloneable)this).Clone();
        }

        public override string ToString()
        {
            return "Clientul: " + nume + " " + prenume + ", are rezervare: " + base.ToString();
        }
    }
}
