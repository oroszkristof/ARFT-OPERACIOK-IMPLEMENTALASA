using System;

namespace InvestmentSystem
{
    public class AdatvedelemTajekoztato
    {
        public int TajekoztatoId { get; set; }
        public string Szoveg { get; set; }
        public DateTime UtolsoFrissites { get; set; }

        public string Megjelenites(int tajekoztatoId)
        {
            // Megjeleníti a tájékoztatót
            if (TajekoztatoId == tajekoztatoId)
            {
                Console.WriteLine($"Adatvédelmi tájékoztató megjelenítve: {TajekoztatoId}");
                return Szoveg;
            }
            return "Tájékoztató nem található.";
        }

        public void Frissites(string szoveg)
        {
            // Frissíti a tájékoztató szövegét
            Szoveg = szoveg;
            UtolsoFrissites = DateTime.Now;
            Console.WriteLine($"Adatvédelmi tájékoztató frissítve: {UtolsoFrissites}");
        }
    }
}