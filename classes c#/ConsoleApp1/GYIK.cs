using System;
using System.Collections.Generic;

namespace InvestmentSystem
{
    public class GYIK
    {
        public int GyikId { get; set; }
        public string Kerdes { get; set; }
        public string Valasz { get; set; }
        private static List<GYIK> gyikLista = new List<GYIK>();

        public List<GYIK> Kereses(string kulcsszo)
        {
            // Keres a GYIK bejegyzések között
            Console.WriteLine($"Keresés kulcsszóra: {kulcsszo}");
            return gyikLista.FindAll(g => g.Kerdes.Contains(kulcsszo) || g.Valasz.Contains(kulcsszo));
        }


        public void Hozzaadas(string kerdes, string valasz)
        {
            // Új GYIK bejegyzést ad hozzá
            Kerdes = kerdes;
            Valasz = valasz;
            GyikId = gyikLista.Count + 1;
            gyikLista.Add(this);
            Console.WriteLine($"GYIK hozzáadva: {Kerdes}");
        }
    }
}