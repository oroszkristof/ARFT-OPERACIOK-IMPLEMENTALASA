using System;

namespace InvestmentSystem
{
    public class Tranzakcio
    {
        public int TranzakcioId { get; set; }
        public int ReszvenyId { get; set; }
        public int Mennyiseg { get; set; }

        public void Vasarlas(int reszvenyId, int mennyiseg)
        {
            // Végrehajt egy vásárlási tranzakciót
            ReszvenyId = reszvenyId;
            Mennyiseg = mennyiseg;
            Console.WriteLine($"Vásárlás: {Mennyiseg} db (Részvény ID: {ReszvenyId})");
        }

        public void Eladas(int reszvenyId, int mennyiseg)
        {
            // Végrehajt egy eladási tranzakciót
            ReszvenyId = reszvenyId;
            Mennyiseg = mennyiseg;
            Console.WriteLine($"Eladás: {Mennyiseg} db (Részvény ID: {ReszvenyId})");
        }
    }
}