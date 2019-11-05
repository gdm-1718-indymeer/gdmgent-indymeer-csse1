using System;

namespace Opdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
                

            Console.WriteLine("Hello World!");
            int SomResul = Som(5, 6);
            Console.WriteLine("De som is: " + SomResul);

            int VerschilResul = Verschil(8, 5);
            Console.WriteLine("Het verschil is: " + VerschilResul);

            int ProductResul = Product(5, 3);
            Console.WriteLine("Het product is: " + ProductResul);

            int QuotientResul = Quotient(8, 4);
            Console.WriteLine("De deling is: " + QuotientResul);
            
            int ModuloResul = Modulo(9, 2);
            Console.WriteLine("De Modulo is: " + ModuloResul);

            int VerhogenResul = Verhogen(7);
            Console.WriteLine("Verhogen is: " + VerhogenResul);

            int VerlagenResul = Verlagen(8);
            Console.WriteLine("Verhogen is: " + VerlagenResul);

            int RandomResul = RandomNumber();
            Console.WriteLine("Random nummer is : " + RandomResul);

            int RandomResulBer = RandomNumberBer(0, 80);
            Console.WriteLine("Random nummer tussen waarde 0 & 80 is : " + RandomResulBer);

            Fibonacci(10);

            Faculteit(5);

            
        }

// rekenmachine

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

        static int Modulo(int getal1, int getal2){
                return getal1%getal2;
            }

         static int Verhogen(int getal1){
                return getal1++;
            }
         static int Verlagen(int getal1){
                return getal1--;
            }

         static int RandomNumber()  
        {  
            Random random = new Random();  
            return random.Next();  
        }  

        static int RandomNumberBer(int min, int max)  
        {  
            Random random = new Random();  
            return random.Next(min, max);  
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
