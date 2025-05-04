using System;
using System.Collections.Generic;

namespace InvestmentSystem
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        public string Nev { get; set; }
        public string Leiras { get; set; }
        private static List<Kategoria> kategoriak = new List<Kategoria>();

        public void Hozzaadas(string nev)
        {
            // Új kategóriát ad a fórumhoz
            Nev = nev;
            Leiras = $"Leírás: {Nev}";
            KategoriaId = kategoriak.Count + 1;
            kategoriak.Add(this);
            Console.WriteLine($"Kategória hozzáadva: {Nev}");
        }

        public List<Kategoria> Listazas()
        {
            // Visszaadja a kategóriák listáját
            Console.WriteLine("Kategóriák listázása...");
            return kategoriak;
        }
    }
}