using System;    
    
namespace oefening1
{
    public class Student : Gebruiker
    {
        // Velden

        // Properties

        // Constructors
        public Student (string voornaam, string familienaam, char geslacht) : base(voornaam, familienaam, geslacht){
            // Genereer Wachtwoord
            base.wachtwoord = GenereerWachtwoord();
            base.gebruikersnaam = GenereerGebruikersnaam(voornaam, familienaam);
            base.login = GenereerLogin(this.gebruikersnaam);
            this.LogOutput();

        }

        
        // Methoden
        private string GenereerWachtwoord()
        {
             string psw = "hackingpasswdStudent";
            return GetHashString(psw);
        }

        private string GenereerGebruikersnaam(string voornaam, string familienaam)
        {
            string gebruikersnaam ="";
            string gVoornaam = GetString(voornaam, 4);
            string gFamilienaam = GetString(familienaam, 4);
            gebruikersnaam = gVoornaam.ToLower() + gFamilienaam.ToLower();

            return gebruikersnaam;
        }

        private string GenereerLogin(string gebruikersnaam)
        {
            string studentL = gebruikersnaam + "@student.arteveldehs.be";

            return studentL;
        }

        public void LogOutput()
        {
            Console.WriteLine(String.Format("Output: Voornaam: {0}, Familienaam: {1}, Geslacht: {2}, geslacht: {3}, Gebruikersnaam: {4}, Login: {5}, Wachtwoord: {6}", this.voornaam, Naam, Geslacht, this.geslacht, Gebruikersnaam, Login, Wachtwoord));
        }
    }
}