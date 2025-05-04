using System;

namespace InvestmentSystem
{
    public class BefektetésiJavaslat
    {
        public int JavaslatId { get; set; }
        public int ReszvenyId { get; set; }
        public float Kockazat { get; set; }

        public void Generalas()
        {
            // Generál egy új befektetési javaslatot
            Random rand = new Random();
            ReszvenyId = rand.Next(1, 100);
            Kockazat = (float)rand.NextDouble() * 10;
            Console.WriteLine($"Befektetési javaslat generálva: Részvény ID: {ReszvenyId}, Kockázat: {Kockazat}");
        }

        public string Megjelenites(int javaslatId)
        {
            // Megjeleníti a javaslat részleteit
            if (JavaslatId == javaslatId)
            {
                Console.WriteLine($"Javaslat megjelenítve: {JavaslatId}");
                return $"Javaslat ID: {JavaslatId}, Részvény ID: {ReszvenyId}, Kockázat: {Kockazat}";
            }
            return "Javaslat nem található.";
        }
    }
}