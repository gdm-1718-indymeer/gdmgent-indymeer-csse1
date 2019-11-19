using System;    
    
namespace oefening1
{
    public class Gebruiker : Persoon1
    {
        // Velden
        protected string gebruikersnaam;
        protected string wachtwoord;
        protected string login;

        // Properties
        public string Gebruikersnaam
        {
            get
            {
                return gebruikersnaam;
            }
        }

        public string Wachtwoord
        {
            get
            {
                return wachtwoord;
            }
        }

         public string Login
        {
            get
            {
                return login;
            }
        }



        // Constructors
        public Gebruiker (string voornaam, string familienaam, char geslacht, string test)
        {
            this.voornaam = voornaam;
            Naam = familienaam;
            Geslacht = geslacht;
        }

        public Gebruiker (string voornaam, string familienaam, char geslacht) : base(voornaam, familienaam, geslacht){
            this.LogOutput();
            // Genereer Wachtwoord
            this.wachtwoord = GenereerWachtwoord();
            this.gebruikersnaam = GenereerGebruikersnaam();
            this.login = GenereerLogin();
        }

        


        // Methoden
        private string GenereerWachtwoord()
        {
            return "GebruikerGW";
        }

        private string GenereerGebruikersnaam()
        {
            /* code for generating user
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
 */
            return "GebruikerGN";
        }

        private string GenereerLogin()
        {
            return "GebruikerL";
        }

        public void LogOutput()
        {
            Console.WriteLine(String.Format("Output : Voornaam: {0}, Familienaam: {1}, Geslacht: {2}, geslacht: {3}, Gebruikersnaam: {4}, Login: {5}, Wachtwoord: {6}", this.voornaam, Naam, Geslacht, this.geslacht, Gebruikersnaam, Login, Wachtwoord));
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}