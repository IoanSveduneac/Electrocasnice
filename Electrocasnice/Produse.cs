using System;
using System.IO;

namespace Modele
{
    public class Produse
    {
        public int cod, pretPiesa, pretTotal;
        public string numeP, numePiesaSchimb;

        public Produse(int cod, string numeP, string numePiesaSchimb, int pretPiesa, int pretTotal)
        {
            this.cod = cod;
            this.numeP = numeP;
            this.numePiesaSchimb = numePiesaSchimb;
            this.pretPiesa = pretPiesa;
            this.pretTotal = pretTotal;
        }

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        public string NumeP
        {
            get { return numeP; }
            set { numeP = value; }
        }

        public string NumePiesaSchimb
        {
            get { return numePiesaSchimb; }
            set { numePiesaSchimb = value; }
        }

        public int PretPiesa
        {
            get { return pretPiesa; }
            set { pretPiesa = value; }
        }

        public int PretTotal
        {
            get { return pretTotal; }
            set { pretTotal = value; }
        }

        

    }
}