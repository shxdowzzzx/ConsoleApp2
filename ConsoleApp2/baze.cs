using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Angajat
    {
        string Nume;
        double Salariu;
        string Departament;
        string Valuta;
        public Angajat(string nume, double salariu, string valuta, string departament)
        {
            Nume = nume;
            Salariu = salariu;
            Valuta = valuta;
            Departament = departament;

        }

        public void AfisareDetalii()
        {
            Console.WriteLine($"Numele angajatului este {Nume}, salariul de {Salariu} {Valuta}, departamentul {Departament}.");
        }



    }
}
