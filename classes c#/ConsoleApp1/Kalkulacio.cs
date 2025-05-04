using System;

namespace InvestmentSystem
{
    public class Kalkulacio
    {
        public int KalkulacioId { get; set; }
        public float Hozam { get; set; }
        public float Veszteseg { get; set; }

        public void Szamitas()
        {
            // Kiszámítja a hozamot és veszteséget
            Random rand = new Random();
            Hozam = (float)rand.NextDouble() * 20;
            Veszteseg = (float)rand.NextDouble() * 10;
            Console.WriteLine($"Kalkuláció: Hozam: {Hozam}%, Veszteség: {Veszteseg}%");
        }

        public string Riport(int kalkulacioId)
        {
            // Riportot készít a kalkulációról
            if (KalkulacioId == kalkulacioId)
            {
                Console.WriteLine($"Kalkulációs riport: {KalkulacioId}");
                return $"Hozam: {Hozam}%, Veszteség: {Veszteseg}%";
            }
            return "Kalkuláció nem található.";
        }
    }
}