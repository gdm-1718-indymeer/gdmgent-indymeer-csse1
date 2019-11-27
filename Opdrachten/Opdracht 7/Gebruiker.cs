using System;    
using System.Security.Cryptography;
using System.Text;
    
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
       /*  public Gebruiker (string voornaam, string familienaam, char geslacht, string test)
        {
            this.voornaam = voornaam;
            Naam = familienaam;
            Geslacht = geslacht;
        }
*/
        public Gebruiker (string voornaam, string familienaam, char geslacht) : base(voornaam, familienaam, geslacht){
            // Genereer Wachtwoord
            this.wachtwoord = GenereerWachtwoord();
            this.gebruikersnaam = GenereerGebruikersnaam(voornaam, familienaam);
            this.login = GenereerLogin(gebruikersnaam);
            this.LogOutput();

        }

    
        // Methoden
        private string GenereerWachtwoord()
        {
            string psw = "hackingpasswd";
           return GetHashString(psw);
        }

        private string GenereerGebruikersnaam(string voornaam, string familienaam)
        {
            string gebruikersnaam = "";
            string gVoornaam = GetString(voornaam, 2);
            string gFamilienaam = GetString(familienaam, 3);
            gebruikersnaam = gVoornaam.ToLower() + gFamilienaam.ToLower();

            return gebruikersnaam;
        }

        private string GenereerLogin(string gebruikersnaam)
        {
            string loginN = gebruikersnaam + "@arteveldehs.be";

            return loginN;
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
        protected string GetString(string startIndex, int length){
            return startIndex.Substring(0, length);
        }

        public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}