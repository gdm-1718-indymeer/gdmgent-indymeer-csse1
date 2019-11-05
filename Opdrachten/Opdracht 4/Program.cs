using System;

namespace opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int cijfer1 = 8;
            int cijfer2 = 3;


            int resultaat1 = Som(cijfer1, cijfer2);
            Console.WriteLine("De som is: " + resultaat1);

             int resultaat2 = Verschil(cijfer1, cijfer2);
            Console.WriteLine("Het verschil is: " + resultaat2);

             int resultaat3 = Product(cijfer1, cijfer2);
            Console.WriteLine("Het product is: " + resultaat3);

             int resultaat4 = Quotient(cijfer1, cijfer2);
            Console.WriteLine("De deling is: " + resultaat4);

            Fibonacci(cijfer1);

            Faculteit(cijfer2);

        }

        static int Som(int getal1, int getal2){
            return getal1 + getal2;
        }
        static int Verschil(int getal1, int  getal2)
        {
            return getal1 - getal2;
        }
        static int Quotient(int getal1, int getal2)
        {
            return getal1 / getal2;
        }
        static int Product(int getal1, int getal2)
        {
            return getal1 * getal2;
        }
         static void Fibonacci(int getal) {
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
                Console.WriteLine("Fibonacci: " + next);
            }
        }

        static void Faculteit(int getal) {
            int fac = getal;

            while(getal > 2) {
                getal--;
                fac *= getal;
            }

            Console.WriteLine("Faculteit is: " + fac);
        }
    }
}