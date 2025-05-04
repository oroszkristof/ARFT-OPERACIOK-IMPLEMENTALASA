using System;
using System.Collections.Generic;

namespace InvestmentSystem
{
    public class AdatkezelésiNaplo
    {
        public int NaploId { get; set; }
        public int UserId { get; set; }
        public string Muvelet { get; set; }
        private static List<AdatkezelésiNaplo> naplok = new List<AdatkezelésiNaplo>();

        public void Naplozas(int userId, string muvelet)
        {
            // Rögzíti az adatkezelési műveletet
            UserId = userId;
            Muvelet = muvelet;
            NaploId = naplok.Count + 1;
            naplok.Add(this);
            Console.WriteLine($"Adatkezelési művelet naplózva: {Muvelet} (Felhasználó: {UserId})");
        }

        public List<AdatkezelésiNaplo> Listazas()
        {
            // Visszaadja a naplóbejegyzéseket
            Console.WriteLine("Adatkezelési napló listázása...");
            return naplok;
        }
    }
}