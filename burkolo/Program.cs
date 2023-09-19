using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burkolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a szélességet.");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Adja meg a hosszusága.");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Adja meg a magasságát.");
            double c = Convert.ToDouble(Console.ReadLine());

            double terulet = 2 * (a + b) * c + a * b;
            double terulet10 = terulet * 1.10;

            double csempe = terulet10 / 1.44;
            Console.WriteLine($"\n A terület:{terulet} \n Ennyi csempe kell:{Math.Ceiling(csempe)} ");

            Console.ReadKey();
        }
    }
}
