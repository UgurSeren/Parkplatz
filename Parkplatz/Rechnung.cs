using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatz
{
    internal class Rechnung
    {
        
        DateTime dateTime = new DateTime();
        Parkplatz parkplatz { set; get; }
        Auto auto { set; get; }

        public void RechnungErzeugen(Auto a,Parkplatz p)
        {
            parkplatz = p;
            auto=a;
            parkplatz.stunde = p.stunde;
            
            
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Rechnung\t\t Datum:{dateTime.Date}");
            Console.WriteLine($"Name:{auto.fahrer} \nPreis:{parkplatz.preis}\n{parkplatz.stunde}");
            Console.WriteLine($"Gesamt:{parkplatz.preis*parkplatz.stunde} Euro");
        }
    }
}
