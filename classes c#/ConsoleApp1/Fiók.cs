using System;

namespace InvestmentSystem
{
    public class Fiok
    {
        public int FiokID { get; set; }
        public string Nyelv { get; set; }
        public DateTime UtolsoBejelentkezes { get; set; }

        public void AdatModositas(string nyelv)
        {
            // Módosítja a fiók beállításait
            if (string.IsNullOrEmpty(nyelv))
            {
                Console.WriteLine("Érvénytelen nyelv.");
                return;
            }

            Nyelv = nyelv;
            Console.WriteLine($"Fiók nyelve módosítva: {Nyelv}");
        }

        public void Torles()
        {
            // Véglegesen törli a fiókot
            Console.WriteLine($"Fiók törölve, ID: {FiokID}");
            FiokID = 0; // Szimulált törlés
        }
    }
}