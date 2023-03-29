
using System.IO;



namespace Modele
{
    public class ManageriereFisier
    {

        public static void SalvareinFisier(int cnp, string nume, string prenume,int cod, string numeP, string numePiesaSchimb, int pretPiesa, int pretTotal)
        {
            using (StreamWriter writer = new StreamWriter("Persoane.txt"))
            {
                writer.Write("CNP: ");
                writer.WriteLine(cnp);
                writer.Write("Nume: ");
                writer.WriteLine(nume);
                writer.Write("Prenume: ");
                writer.WriteLine(prenume);
                writer.Write("Cod: ");
                writer.WriteLine(cod);
                writer.Write("Nume produs: ");
                writer.WriteLine(numeP);
                writer.Write("Nume piesa de schimb: ");
                writer.WriteLine(numePiesaSchimb);
                writer.Write("Pret piesa schimb: ");
                writer.WriteLine(pretPiesa);
                writer.Write("Pret total: ");
                writer.WriteLine(pretTotal);
            }
        }

        public static void CitestedinFisier(string filePath)
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
                            case "CNP":
                                string cnp = val;

                                break;
                            case "Nume":
                                string nume = val;

                                break;
                            case "Prenume":
                                string prenume = val;

                                break;
                            case "Cod":
                                string cod = val;

                                break;
                            case "Nume produs":
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
