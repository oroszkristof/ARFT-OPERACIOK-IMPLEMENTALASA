using System;

namespace InvestmentSystem
{
    public class Felhasznalo
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Jelszo { get; set; }
        public DateTime UtolsoBejelentkezes { get; set; }
        public bool ElőfizetettE { get; set; }
        public int PozitivKereskedésekSzama { get; set; }
        public int NegativKereskedésekSzama { get; set; }

        public bool Regisztracio(string email, string jelszo)
        {
            // Ellenőrzi az e-mailt és jelszót, majd belépteti a felhasználót
            if (string.IsNullOrEmpty(email) || !email.Contains("@") || string.IsNullOrEmpty(jelszo) || jelszo.Length < 6)
            {
                Console.WriteLine("Érvénytelen e-mail vagy jelszó.");
                return false;
            }

            Email = email;
            Jelszo = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(jelszo)); // Egyszerű titkosítás
            UtolsoBejelentkezes = DateTime.Now;
            Console.WriteLine($"Felhasználó regisztrálva: {Email}");
            return true;
        }

        public void Kijelentkezes()
        {
            // Kijelentkezteti a felhasználót
            UtolsoBejelentkezes = DateTime.Now;
            Console.WriteLine($"Felhasználó kijelentkezett: {Email}");
        }
    }
}