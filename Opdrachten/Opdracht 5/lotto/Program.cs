using System;
using System.Collections.Generic;
using System.Threading;



namespace lotto

{
    class Program
    {
        static void Main(string[] args)
        {
    
        const int lengthNumbers = 6;

        Random r = new Random();
        // store the numbers, list works like an array. 
        // using int because we're working with numbers
        List<int> lotteryNumbers = new List<int>();
        Console.WriteLine("The numbers are:\n");
        while (lotteryNumbers.Count < lengthNumbers)
        {
            int lottoNumber = r.Next(1, 46); // Generate random number from 1 - 45
            if (!lotteryNumbers.Contains(lottoNumber))
            {
                lotteryNumbers.Add(lottoNumber);
                Console.WriteLine(lottoNumber);
                Thread.Sleep(5000);


            }
        }

        // write "," after each number
       // Console.WriteLine(String.Join(", ", lotteryNumbers.ToArray()));
        }

           
        }


}
