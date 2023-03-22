﻿using Modele;

using System;

namespace Electrocasnice
{
    class Program
    {
        static void Main(string[] args)
        {
            Produse p = new Produse(123,"Aspirator","Roti",27,169);
            Console.WriteLine("Nume produs " + p.NumeP + " cod:" + p.Cod);
            p.ScriereFisier();
            p.CitireFisier();
            Persoana c = new Persoana(3255346,"Mihai","Apopei");
            Console.WriteLine("Nume " + c.Nume + " cnp" + c.Cnp);
            c.ScriereFisier();
            c.CitireFisier();
        }
    }
}
