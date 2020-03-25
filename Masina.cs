using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator2
{
    class Masina
    {
        string NumeFirma;
        string Model;
        int AnFabricatie;
        string Culoare;
        double Pret;
        string Optiune1;
        string Optiune2;

        public Masina()
        {
            NumeFirma = string.Empty;
            Model = string.Empty;
            AnFabricatie = 0;
            Culoare = string.Empty;
            Pret = 0;
            Optiune1 = string.Empty;
            Optiune2 = string.Empty;
        }

        public Masina(string NumeFirma, string Model, int AnFabricatie, string Culoare, double Pret, string Optiune1, string Optiune2)
        {
            this.NumeFirma = NumeFirma;
            this.Model = Model;
            this.AnFabricatie = AnFabricatie;
            this.Culoare = Culoare;
            this.Pret = Pret;
            this.Optiune1 = Optiune1;
            this.Optiune2 = Optiune2;
        }

        public void infoMasina() //Afiseaza date despre masina
        {
            Console.WriteLine("Masina: {0}\nModel: {1}\nAn Fabricatie: {2}\nCuloare: {3}\nPret: {4}\nOptiune1: {5}\nOptiune2: {6}$\n", NumeFirma, Model, AnFabricatie, Culoare, Pret, Optiune1, Optiune2);
        }
    }
}
