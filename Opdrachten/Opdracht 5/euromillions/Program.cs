using System;
using System.Collections.Generic;
using System.Threading;



namespace euromillions

{
    class Program
    {
        static void Main(string[] args)
        {
    
        const int lengthNumbers = 5;
        const int StarLength = 2;

        Random r = new Random();
        // store the numbers, list works like an array. 
        // using int because we're working with numbers
        List<int> lotteryNumbers = new List<int>();

        
        Console.WriteLine("The numbers are:\n");

        while (lotteryNumbers.Count < lengthNumbers)
        {
            int lottoNumber = r.Next(1, 51); // Generate random number from 1 - 45
            if (!lotteryNumbers.Contains(lottoNumber))
            {
                lotteryNumbers.Add(lottoNumber);
                Console.WriteLine(lottoNumber);
                Thread.Sleep(2000);


            }
        };
        
        List<int> StarNumbers = new List<int>();

         Console.WriteLine("\nThe extra stars are:\n");

         while (StarNumbers.Count < StarLength)
        {
            int starNumber = r.Next(1, 13); // Generate random number from 1 - 12
            if (!StarNumbers.Contains(starNumber))
            {
                StarNumbers.Add(starNumber);
                Console.WriteLine("* " + starNumber);
                Thread.Sleep(2000);


            }
        }

        // write "," after each number
       // Console.WriteLine(String.Join(", ", lotteryNumbers.ToArray()));
        }

           
        }


}
