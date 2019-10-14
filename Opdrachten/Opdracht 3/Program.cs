using System;

namespace opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            
            // Alle tafels.
            program.AlleTafels();
            
            // Tafel.
            Console.WriteLine("Geef een getal in:");
            int tafel = Convert.ToInt32(Console.ReadLine());
            program.Tafel(tafel);
            
            // Factulteit.
            Console.WriteLine("Geef een getal in:");
            int getal = Convert.ToInt32(Console.ReadLine());
            program.Faculteit(getal);

            // Faculteit 10.
            program.Faculteit(10);
            
            // Fibonacci.
            Console.WriteLine("Geef een eindgetal in:");
            int eindfib = Convert.ToInt32(Console.ReadLine());
            program.Fibonacci(eindfib);
        }

        void Tafel(int getal) {
            for(int i = 0; i <= 5; i++) {
                Console.WriteLine(i + " * " + getal + " = " + (i*getal));
            }
        }

        void AlleTafels() {
            for(int i = 1; i <= 5; i++) {
                Console.WriteLine("Tafel van: " + i);
                for(int j = 1; j <= 5; j++) {
                    Console.WriteLine(i + " * " + j + " = " + i*j);
                }
            }
        }

        void Fibonacci(int getal) {
            int g0 = 0;
            int g1 = 1;
            int next = 0;

            for(int i = 0; i < getal; i++) {
                if(i == 0) {
                    next = 0;
                } else if(i == 1) {
                    next = 1;
                } else {
                    next = g0 + g1;
                    g0 = g1;
                    g1 = next;
                }
                Console.WriteLine(next);
            }
        }

        void Faculteit(int getal) {
            int fac = getal;

            while(getal > 2) {
                getal--;
                fac *= getal;
            }

            Console.WriteLine(fac);
        }
    }
}
