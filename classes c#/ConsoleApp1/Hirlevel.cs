using System;

namespace InvestmentSystem
{
    public class Hirlevel
    {
        public int HirlevelId { get; set; }
        public string Tartalom { get; set; }
        public DateTime KuldesIdopont { get; set; }

        public void Kuldes()
        {
            // Elküldi a hírleveplore
            Console.WriteLine($"Hírlevél elküldve: {Tartalom} ({KuldesIdopont})");
        }

        public void Generalas(string tartalom)
        {
            // Létrehozza a hírlevél tartalmát
            Tartalom = tartalom;
            KuldesIdopont = DateTime.Now;
            Console.WriteLine($"Hírlevél generálva: {Tartalom}");
        }
    }
}