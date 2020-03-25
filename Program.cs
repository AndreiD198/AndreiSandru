using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clasa Persoana: ");

            Persoana p = new Persoana();
            p.infoPersoana();

            Persoana p1 = new Persoana("Sandru", "Andrei", "Carseller");
            p1.infoPersoana();

            Console.WriteLine("\nClasa Masina: ");
            Masina m = new Masina();
            m.infoMasina();

            Masina m1 = new Masina("SEAT", "IBIZA", 2010, "ALB", 4500, "oglinzi electrice", "inclazire in scaune");
            m1.infoMasina();
        }
    }
}
