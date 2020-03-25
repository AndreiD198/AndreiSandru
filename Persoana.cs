using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator2
{
    class Persoana
    {
        string nume;
        string prenume;
        string TipPersoana;

        public Persoana()
        {
            nume = string.Empty;
            prenume = string.Empty;
            TipPersoana = string.Empty;
        }

        public Persoana(string nume, string prenume, string TipPersoana)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.TipPersoana = TipPersoana;
        }

        public void infoPersoana()
        {
            Console.WriteLine("Nume " + TipPersoana + ": {0} {1}", nume, prenume);
        }
    }
}
