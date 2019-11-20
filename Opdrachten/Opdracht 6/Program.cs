using System;

namespace oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Persoon1 p1 = new Persoon1();
            p1.voornaam = "Kristof";
            p1.Geslacht = 'M';
            p1.Naam = "Raes";
            p1.LogOutput();
            Persoon1 p2 = new Persoon1("Parent", "Olivier", 'M');
            p2.LogOutput();
            Gebruiker gebruiker = new Gebruiker("Kristof", "Raes", 'M');
            Console.WriteLine("--test1--");
            Gebruiker gebruiker1 = new Gebruiker("Evelien", "Rutsaert", 'V');
            //Console.WriteLine(String.Format("Gebruiker: Naza",) + gebruiker1.Wachtwoord);
            Console.WriteLine("--test2--");
            Student student1 = new Student("Evelien", "Rutsaert", 'V');
            Console.WriteLine("--test3--");
            Docent docent1 = new Docent("Kristof", "Raes", 'O');
        }
    }

}
