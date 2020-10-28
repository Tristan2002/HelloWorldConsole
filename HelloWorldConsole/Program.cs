using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rekenen;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("Hello class");

            Console.Write("Wat is uw naam? ");

            var ingevuld = Console.ReadLine();

            Console.WriteLine($"Hallo {ingevuld}");

            Console.Write("Getal1 =");
            ingevuld = Console.ReadLine();
            int getal1 = int.Parse(ingevuld);

            Console.Write("Getal2 =");
            ingevuld = Console.ReadLine();
            int getal2 = int.Parse(ingevuld);

            int som = Rekenaar.TelOp(getal1, getal2);
            int product = Rekenaar.Vermenigvuldig(getal1, getal2);

            Console.WriteLine($"De som van {getal1} en {getal2} is {som}");
            Console.WriteLine($"Het product van {getal1} en {getal2} is {product}");

            Console.ReadLine();

            if (ingevuld == "Tristan")
            {
                Console.WriteLine("Your name is the same as the writer of this code!");
            }
        }
    }
}
