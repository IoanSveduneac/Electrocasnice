using System;
using System.IO;

namespace Modele
{
    public class Produse
    {
        private int cod, pretPiesa, pretTotal;
        private string numeP, numePiesaSchimb;

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

        public void ScriereFisier()
        {
            using (StreamWriter writer = new StreamWriter("Produse.txt"))
            {
                writer.Write("Cod: ");
                writer.WriteLine(cod);
                writer.Write("Nume produs: ");
                writer.WriteLine(numeP);
                writer.Write("Nume piesa de schimb: ");
                writer.WriteLine(numePiesaSchimb);
                writer.Write("Nume piesa schimb: ");
                writer.WriteLine(pretPiesa);
                writer.Write("Pret total: ");
                writer.WriteLine(pretTotal);
            }
        }
        public void CitireFisier()
        {
            using (StreamReader reader = new StreamReader("Produse.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string var = parts[0].Trim();
                        string val = parts[1].Trim();

                        switch (var)
                        {
                            case "Cod":
                                string cod = val;
                                
                                break;
                            case "Nume":
                                string numeP = val;
                                
                                break;
                            case "Nume piesa de schimb":
                                string numePiesaSchimb = val;
                                
                                break;
                            case "Pret piesa schimb":
                                int pretPiesa = int.Parse(val);

                                break;
                            case "Pret total":
                                int pretTotal = int.Parse(val);

                                break;
                            default:
                                
                                break;
                        }
                    }
                }
            }
        }

    }
}