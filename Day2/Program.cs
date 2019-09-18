using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Subway [] rerA = {
                new Subway(12, "NOTE","Boissy-St-Léger", "1"),
                new Subway(110, "NANI", "Boissy-St-Léger", "1"),
                new Subway(34, "QCOQ", "Marne-la-Vallée", "A"),
                new Subway(3, "ONIX", "Torcy", "1"),
                new Subway(233, "UZAR", "Cergy-le-haut", "B")
            };

            foreach (var subway in rerA) {
                Console.WriteLine($"********* N°{subway.ID}**********");
                Console.WriteLine($"Train : {subway.name} \nDestination: {subway.destination} \nQuaie: {subway.quaie}");
                Console.WriteLine("********************** \n");

            }
        }
    }

}
