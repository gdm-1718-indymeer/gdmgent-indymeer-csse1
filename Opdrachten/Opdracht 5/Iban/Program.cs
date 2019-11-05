using System;
using System.Text;

namespace Iban
{
    class Program
    {
        static void Main(string[] args)
        {
           Validate("BE32 8909 5424 4302");
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
        static string GetString(string startIndex, int length){
            return startIndex.Substring(0, length);
        }


    }
    
}
