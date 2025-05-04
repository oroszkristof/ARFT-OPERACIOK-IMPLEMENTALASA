using System;

namespace InvestmentSystem
{
    public class ExportaltEredmeny
    {
        public int ExportId { get; set; }
        public string FajlNev { get; set; }
        public DateTime LetoltesDatum { get; set; }

        public void Exportalas()
        {
            // Exportálja az eredményeket PDF-be
            FajlNev = $"export_{ExportId}.pdf";
            LetoltesDatum = DateTime.Now;
            Console.WriteLine($"Eredmények exportálva: {FajlNev}");
        }

        public string Letoltes(int exportId)
        {
            // Letölthetővé teszi a fájlt
            if (ExportId == exportId)
            {
                Console.WriteLine($"Fájl letöltése: {FajlNev}");
                return FajlNev;
            }
            return "Export nem található.";
        }
    }
}