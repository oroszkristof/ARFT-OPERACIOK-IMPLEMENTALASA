using System;

namespace InvestmentSystem
{
    public class Ertesites
    {
        public int ErtesitesId { get; set; }
        public int UserId { get; set; }
        public string Uzenet { get; set; }

        public void Kuldes(int userId)
        {
            // Elküldi az értesítést a felhasználónak
            UserId = userId;
            Console.WriteLine($"Értesítés elküldve felhasználónak (ID: {UserId}): {Uzenet}");
        }

        public void Torles(int ertesitesId)
        {
            // Törli az értesítést
            if (ErtesitesId == ertesitesId)
            {
                Console.WriteLine($"Értesítés törölve: {ErtesitesId}");
                Uzenet = null;
            }
        }
    }
}