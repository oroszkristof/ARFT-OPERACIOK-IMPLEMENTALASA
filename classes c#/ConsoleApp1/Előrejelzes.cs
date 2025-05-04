using System;

namespace InvestmentSystem
{
    public class Előrejelzes
    {
        public int ElorejelzesId { get; set; }
        public DateTime Datum { get; set; }
        public float Ertek { get; set; }

        public void Generalas()
        {
            // Generál egy hosszú távú előrejelzést
            Random rand = new Random();
            Datum = DateTime.Now.AddDays(30);
            Ertek = rand.Next(100, 1000);
            Console.WriteLine($"Hosszú távú előrejelzés generálva: {Ertek} ({Datum})");
        }

        public string Megjelenites(int elorejelzesId)
        {
            // Megjeleníti az előrejelzés részleteit
            if (ElorejelzesId == elorejelzesId)
            {
                Console.WriteLine($"Előrejelzés megjelenítve: {ElorejelzesId}");
                return $"Előrejelzés ID: {ElorejelzesId}, Dátum: {Datum}, Érték: {Ertek}";
            }
            return "Előrejelzés nem található.";
        }
    }
}