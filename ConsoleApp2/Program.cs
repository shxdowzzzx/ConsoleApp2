namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Angajat("Alexei", 8250, "$", "IT");
            var b = new Angajat("Daniel", 7500, "$", "Marketing");
            var c = new Angajat("Mihai", 5000, "$", "Resurse Umane");

            a.AfisareDetalii();
            b.AfisareDetalii();
            c.AfisareDetalii();

        }
    }
}
