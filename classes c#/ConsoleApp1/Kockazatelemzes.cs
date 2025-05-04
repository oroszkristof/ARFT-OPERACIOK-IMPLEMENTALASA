using System;

namespace InvestmentSystem
{
    public class Kockazatelemzes
    {
        public int ElemzesId { get; set; }
        public int PortfolioId { get; set; }
        public float KockazatiSzint { get; set; }

        public void Szamitas(int portfolioId)
        {
            // Kiszámítja a portfólió kockázatát
            PortfolioId = portfolioId;
            Random rand = new Random();
            KockazatiSzint = (float)rand.NextDouble() * 100;
            Console.WriteLine($"Kockázati szint kiszámítva: {KockazatiSzint} (Portfólió ID: {PortfolioId})");
        }

        public string Jelentes()
        {
            // Jelentést készít az elemzésről
            Console.WriteLine("Kockázati jelentés készítése...");
            return $"Kockázati szint: {KockazatiSzint} (Portfólió ID: {PortfolioId})";
        }
    }
}