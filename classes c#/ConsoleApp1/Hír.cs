using System;

namespace InvestmentSystem
{
    public class Hir
    {
        public int HirId { get; set; }
        public string Cim { get; set; }
        public string Forras { get; set; }

        public void Frissites()
        {
            // Frissíti a híreket külső API-ból (szimuláció)
            Cim = "Új piaci hírek";
            Forras = "Finnhub API";
            Console.WriteLine("Hírek frissítve.");
        }

        public string Megjelenites(int hirId)
        {
            // Megjeleníti a kiválasztott hír részleteit
            if (HirId == hirId)
            {
                Console.WriteLine($"Hír megjelenítve: {Cim}");
                return $"Hír: {Cim}, Forrás: {Forras}";
            }
            return "Hír nem található.";
        }
    }
}