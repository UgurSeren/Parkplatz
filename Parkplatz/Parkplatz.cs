using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatz
{
    internal class Parkplatz
    {
        public List<Auto> autos = new List<Auto>();
        public int preis { set; get; } = 5;
        public int stunde { set; get; }
        public Auto auto { set; get; }
       


        public void AddAuto(Auto a)
        {
            Console.WriteLine("Wie viel Stunde möchten Sie parken");
            stunde = Convert.ToInt16(Console.ReadLine());
            autos.Add(a);
            RechnungErstellen(a);
        }
        public void Zeig()
        {
            foreach (var item in autos)
            {
                Console.WriteLine(item.fahrer);
                Console.WriteLine(item.kennzeichnen);
            }
        }
        public void RechnungErstellen(Auto a)
        {
            Rechnung rechnung = new Rechnung();
            Parkplatz p = new Parkplatz();
            p.stunde=stunde;
            
            rechnung.RechnungErzeugen(a,p);

        }
    }
}
