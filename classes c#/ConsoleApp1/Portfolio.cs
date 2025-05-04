using System;

namespace InvestmentSystem
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public float Ertek { get; set; }
        public int UserId { get; set; }

        public void Frissites()
        {
            // Frissíti a portfólió értékét
            Random rand = new Random();
            Ertek = rand.Next(1000, 100000);
            Console.WriteLine($"Portfólió értéke frissítve: {Ertek}");
        }

        public string Megjelenites(int portfolioId)
        {
            // Megjeleníti a portfólió adatait
            if (PortfolioId == portfolioId)
            {
                Console.WriteLine($"Portfólió megjelenítve: {PortfolioId}");
                return $"Portfólió ID: {PortfolioId}, Érték: {Ertek}, Felhasználó ID: {UserId}";
            }
            return "Portfólió nem található.";
        }
    }
}