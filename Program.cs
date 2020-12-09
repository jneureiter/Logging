using System;
using System.Collections.Generic;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Meldung> meldungen = new List<Meldung>();

            Meldung eins = new Meldung();
            eins.FDescription = "Dateizugriff verweigert";
            eins.FDate = "2020-12-18";
            eins.FDate = "Fataler Fehler";

            meldungen.Add(eins);

            Meldung zwei = new Meldung();
            zwei.FDescription = "Speicherplatz zu knapp - die Datei konnte nicht erstellt werden";
            zwei.FDate = "2020-12-07";
            zwei.FSeverity = "Fataler Fehler";

            meldungen.Add(zwei);

            foreach (var item in meldungen)
            {
                Console.WriteLine($" {item.FSeverity}: {item.FDate}     {item.FDescription}");
            }




        }
    }
}
