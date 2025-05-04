using System;
using System.Collections.Generic;

namespace InvestmentSystem
{
    public class Tevékenységnaplo
    {
        public int NaploId { get; set; }
        public string UserId { get; set; }
        public string Tevekenyseg { get; set; }
        private static List<Tevékenységnaplo> naplok = new List<Tevékenységnaplo>();

        public void Naplozas(int userId, string tevekenyseg)
        {
            // Hozzáad egy új bejegyzést a naplóhoz
            UserId = userId.ToString();
            Tevekenyseg = tevekenyseg;
            NaploId = naplok.Count + 1;
            naplok.Add(this);
            Console.WriteLine($"Tevékenység naplózva: {Tevekenyseg} (Felhasználó: {UserId})");
        }

        public List<Tevékenységnaplo> Listazas()
        {
            // Visszaadja a tevékenységek listáját
            Console.WriteLine("Tevékenységnapló listázása...");
            return naplok;
        }
    }
}