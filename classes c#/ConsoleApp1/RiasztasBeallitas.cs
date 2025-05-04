using System;

namespace InvestmentSystem
{
    public class RiasztasBeallitas
    {
        public int RiasztasId { get; set; }
        public int ReszvenyId { get; set; }
        public float CelArfolyam { get; set; }

        public void Beallitas(int reszvenyId, float celArfolyam)
        {
            // Beállít egy új riasztást
            ReszvenyId = reszvenyId;
            CelArfolyam = celArfolyam;
            Console.WriteLine($"Riasztás beállítva: Részvény ID: {ReszvenyId}, Cél árfolyam: {CelArfolyam}");
        }

        public bool Ellenorzes(int ertesitesId)
        {
            // Ellenőrzi, hogy a riasztás feltétele teljesült-e
            Random rand = new Random();
            float aktualisArfolyam = rand.Next(50, 500);
            bool teljesult = aktualisArfolyam >= CelArfolyam;
            Console.WriteLine($"Riasztás ellenőrzés: {teljesult} (Aktuális árfolyam: {aktualisArfolyam})");
            return teljesult;
        }
    }
}