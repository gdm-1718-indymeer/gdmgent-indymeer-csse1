using System;

namespace Les4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            double fahr = 100;
            double cels = (fahr - 32) * (5.0 / 9.0);

            Console.WriteLine(cels); 

            Boolean test;
            test = true; 
            Console.WriteLine(test.ToString());
        }
    }
}
