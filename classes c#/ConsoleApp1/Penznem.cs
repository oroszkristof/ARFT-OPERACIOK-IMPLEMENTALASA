using System;

namespace InvestmentSystem
{
    public class Penznem
    {
        public int PenznemId { get; set; }
        public string Kod { get; set; }
        public float AtvaltasiArfolyam { get; set; }

        public float Atvaltas(float ertek)
        {
            // Átváltja az értéket másik pénznembe
            float atvaltottErtek = ertek * AtvaltasiArfolyam;
            Console.WriteLine($"Átváltás: {ertek} {Kod} -> {atvaltottErtek}");
            return atvaltottErtek;
        }

        public void Frissites()
        {
            // Frissíti az árfolyamot
            Random rand = new Random();
            AtvaltasiArfolyam = (float)rand.NextDouble() * 400;
            Console.WriteLine($"Pénznem árfolyama frissítve: {AtvaltasiArfolyam} ({Kod})");
        }
    }
}