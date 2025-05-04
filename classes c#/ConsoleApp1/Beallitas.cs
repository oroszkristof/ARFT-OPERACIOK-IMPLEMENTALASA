using System;

namespace InvestmentSystem
{
    public class Beallitas
    {
        public int BeallitasId { get; set; }
        public int UserId { get; set; }
        public string ErtesitesMod { get; set; }

        public void Modositas(string ertesitesMod)
        {
            // Módosítja a beállításokat
            ErtesitesMod = ertesitesMod;
            Console.WriteLine($"Értesítési mód módosítva: {ErtesitesMod}");
        }

        public Beallitas Betoltes(int userId)
        {
            // Betölti a felhasználó beállításait
            UserId = userId;
            ErtesitesMod = "e-mail"; // Alapértelmezett érték
            Console.WriteLine($"Beállítások betöltve: Felhasználó ID: {UserId}");
            return this;
        }
    }
}