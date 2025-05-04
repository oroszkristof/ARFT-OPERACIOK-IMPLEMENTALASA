using System;

namespace InvestmentSystem
{
    public class ÜgyfelszolgalatiKeres
    {
        public int KeresId { get; set; }
        public int UserId { get; set; }
        public string Allapot { get; set; }

        public void UjKeres(int userId)
        {
            // Új ügyfélszolgálati kérést rögzít
            UserId = userId;
            Allapot = "folyamatban";
            Console.WriteLine($"Új kérés rögzítve: Felhasználó ID: {UserId}, Állapot: {Allapot}");
        }

        public void AllapotFrissites(int keresId, string allapot)
        {
            // Frissíti a kérés állapotát
            if (KeresId == keresId)
            {
                Allapot = allapot;
                Console.WriteLine($"Kérés állapota frissítve: {Allapot} (Kérés ID: {KeresId})");
            }
        }
    }
}