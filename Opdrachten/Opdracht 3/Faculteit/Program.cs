﻿using System;

namespace opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            
          
            // Factulteit.
            Console.WriteLine("Geef een getal in:");
            int getal = Convert.ToInt32(Console.ReadLine());
            program.Faculteit(getal);

            
           
        }


       
        void Faculteit(int getal) {
            int fac = getal;

            while(getal > 2) {
                getal--;
                fac *= getal;
            }

            Console.WriteLine("Faculteit is: " + fac);
        }
    }
}
