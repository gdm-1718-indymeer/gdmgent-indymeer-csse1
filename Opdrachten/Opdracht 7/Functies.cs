using System; 
using System.Threading;  
using System.Collections.Generic;
using System.Text;


    
namespace oefening1
{
    public static class Functies 
    {
        
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
         static string GetString(string startIndex, int length){
            return startIndex.Substring(0, length);
        }
         static bool Validate(string IBAN)
        { 
            IBAN = IBAN.ToUpper(); 
            string land = GetString(IBAN, 2);

            if (String.IsNullOrEmpty(IBAN)){
                Console.WriteLine("the Iban is empty");
                return false;
            }
            else if(land != "BE"){
                Console.WriteLine("The Iban does not start with BE");
                return false;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(IBAN, "^[A-Z0-9]"))
            {
                IBAN = IBAN.Replace(" ", String.Empty);
                string bank = IBAN.Substring(4, IBAN.Length - 4) + IBAN.Substring(0, 4);
                
                int asciiShift = 55;

                StringBuilder stringBuilder = new StringBuilder();
                foreach (char c in bank)
                {
                    int Validate;
                    if (Char.IsLetter(c)){
                         Validate = c - asciiShift;
                    }else Validate = int.Parse(c.ToString());

                    stringBuilder.Append(Validate);
                }
                string checkSumString = stringBuilder.ToString();
                int checksum = int.Parse(checkSumString.Substring(0, 1));
                
                for (int i = 1; i < checkSumString.Length; i++)
                {
                    int Validate = int.Parse(checkSumString.Substring(i, 1));
                    checksum *= 10;
                    checksum += Validate;
                    checksum %= 97;
                }
                Console.WriteLine("It's valid, you're free to donate");
                return checksum == 1;
            }
            else{
                Console.WriteLine("It's not a valid Iban");
                return false;
            }

        }
        static void Lotto()
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

        }

        static void Euromillions()
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


        }
    }
}