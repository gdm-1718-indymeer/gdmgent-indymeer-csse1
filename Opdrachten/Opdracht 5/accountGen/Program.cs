using System;

namespace accountGen
{
    class Program
    {
        static void Main(string[] args)
        {
             try
            {
                Generate(args[0], args[1], args[2]);
                
            }
            catch (System.IndexOutOfRangeException){
                Console.WriteLine("Te weinig argumenten, probeer student Voornaam Achternaam");
            }
         
        }
        

            static void Generate(string type, string Voornaam, string Achternaam){

               switch(type.ToLower()) {

                   case "docent":
                        string first = GetString(Voornaam, 4);
                        string last = GetString(Achternaam, 2);
                        Console.WriteLine(first.ToLower() + last.ToLower() + "@arteveldehs.be"); 
                    break; 

                    case "student":
                        first = GetString(Voornaam, 4);
                        last = GetString(Achternaam, 4);
                        Console.WriteLine(first.ToLower() + last.ToLower() + "@student.arteveldehs.be");
                    break; 

               }
               return ;
                
            }

            static string GetString(string startIndex, int length){
            return startIndex.Substring(0, length);
        }

    }
}
