using System;

namespace InvestmentSystem
{
    public class TrendElőrejelzes
    {
        public int ElorejelzesId { get; set; }
        public int ReszvenyId { get; set; }
        public float VarhatoArfolyam { get; set; }

        public void Elorejelzes(int reszvenyId)
        {
            // Előrejelzi a részvény árfolyamát
            ReszvenyId = reszvenyId;
            Random rand = new Random();
            VarhatoArfolyam = rand.Next(50, 500);
            Console.WriteLine($"Árfolyam előrejelzés: {VarhatoArfolyam} (Részvény ID: {ReszvenyId})");
        }

        public void Frissites()
        {
            // Frissíti az előrejelzést új adatokkal
            Random rand = new Random();
            VarhatoArfolyam = rand.Next(50, 500);
            Console.WriteLine($"Előrejelzés frissítve: {VarhatoArfolyam}");
        }
    }
}