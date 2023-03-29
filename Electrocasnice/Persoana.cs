using System;
using System.IO;

namespace Modele
{
    public class Persoana
    {
        public int cnp;
        public string nume, prenume;

        public Persoana(int cnp, string nume, string prenume)
        {
            this.cnp = cnp;
            this.nume = nume;
            this.prenume = prenume;
        }

        public int Cnp
        {
            get { return cnp; }
            set { cnp = value; }
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
        
    }
}