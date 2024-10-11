using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkusBkamat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adja meg, hogy hány évre szeretné lekötni a pénzét a bankba");
            int ev = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ev);
            Console.WriteLine("Kérem adja meg, hogy mekkora összeget szeretne lekötni");
            double osszeg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(osszeg);
            Console.WriteLine("Mekkora a kamat");
            double kamat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(kamat);
            double vegosszeg = osszeg * Math.Pow(1 + kamat / 100, ev);

            
            Console.WriteLine($"{ev} év múlva: {vegosszeg:F2} Ft");
        }
    }
}
