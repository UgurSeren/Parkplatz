using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.fahrer = "Ugur Seren";
            auto.kennzeichnen = "OB US 123";
            Parkplatz parkplatz = new Parkplatz();
            parkplatz.AddAuto(auto);
            parkplatz.Zeig();



            Console.ReadKey();
        }
    }
}
