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
    }
}