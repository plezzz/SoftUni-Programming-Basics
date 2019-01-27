using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double area = (l * 100) * (w * 100);
            double bench = area / 10;
            double wardrobe = (a * 100) * (a * 100);
            double clearArea = area - wardrobe - bench;
            Console.WriteLine(Math.Floor(clearArea / (40 + 7000)));
        }
    }
}
