using System;

namespace InvestmentSystem
{
    public class Reszveny
    {
        public int ReszvenyId { get; set; }
        public string Ticker { get; set; }
        public float Arfolyam { get; set; }

        public void Frissites()
        {
            // Frissíti a részvény árfolyamát
            Random rand = new Random();
            Arfolyam = rand.Next(50, 500);
            Console.WriteLine($"Részvény árfolyama frissítve: {Arfolyam} ({Ticker})");
        }

        public string AdatokLekerese(int reszvenyId)
        {
            // Lekéri a részvény adatait
            if (ReszvenyId == reszvenyId)
            {
                Console.WriteLine($"Részvény adatok lekérve: {Ticker}");
                return $"Ticker: {Ticker}, Árfolyam: {Arfolyam}";
            }
            return "Részvény nem található.";
        }
    }
}