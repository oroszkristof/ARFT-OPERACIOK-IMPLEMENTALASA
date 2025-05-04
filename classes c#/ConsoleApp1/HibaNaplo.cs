using System;
using System.Collections.Generic;

namespace InvestmentSystem
{
    public class HibaNaplo
    {
        public int HibaId { get; set; }
        public string Leiras { get; set; }
        public DateTime Idopont { get; set; }
        private static List<HibaNaplo> hibak = new List<HibaNaplo>();

        public void Naplozas(string leiras)
        {
            // Rögzíti a hibát a naplóban
            Leiras = leiras;
            Idopont = DateTime.Now;
            HibaId = hibak.Count + 1;
            hibak.Add(this);
            Console.WriteLine($"Hiba naplózva: {Leiras} ({Idopont})");
        }

        public List<HibaNaplo> Listazas()
        {
            // Visszaadja a hibák listáját
            Console.WriteLine("Hibanapló listázása...");
            return hibak;
        }
    }
}