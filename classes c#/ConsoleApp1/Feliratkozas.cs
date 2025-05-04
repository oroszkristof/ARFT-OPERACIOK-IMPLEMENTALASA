using System;

namespace InvestmentSystem
{
    public class Feliratkozas
    {
        public int FeliratkozasId { get; set; }
        public string Email { get; set; }
        public bool Aktiv { get; set; }

        public void Hozzaadas(string email)
        {
            // Új feliratkozást ad a listához
            if (!email.Contains("@"))
            {
                Console.WriteLine("Érvénytelen e-mail cím.");
                return;
            }
            Email = email;
            Aktiv = true;
            Console.WriteLine($"Feliratkozás hozzáadva: {Email}");
        }

        public void Leiratkozas()
        {
            // Deaktiválja a feliratkozást
            Aktiv = false;
            Console.WriteLine($"Feliratkozás deaktiválva: {Email}");
        }
    }
}