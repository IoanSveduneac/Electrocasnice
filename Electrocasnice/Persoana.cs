using System;
using System.IO;

namespace Modele
{
    public class Persoana
    {
        private int cnp;
        private string nume, prenume;

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
        public void ScriereFisier()
        {
            using (StreamWriter writer = new StreamWriter("Persoane.txt"))
            {
                writer.Write("CNP: ");
                writer.WriteLine(cnp);
                writer.Write("Nume: ");
                writer.WriteLine(nume);
                writer.Write("Prenume: ");
                writer.WriteLine(prenume);
            }
        }
        public void CitireFisier()
        {
            using (StreamReader reader = new StreamReader("Persoane.txt"))
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
                                case "CNP":
                                    string cnp = val;

                                    break;
                                case "Nume":
                                    string nume = val;

                                    break;
                                case "Prenume":
                                    string  prenume = val;

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