using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volume = w * l * h;
            double litters = volume * 0.001;
            double percentCovert = percent * 0.01;
            double realLitters = litters * (1 - percentCovert);
            Console.WriteLine($"{realLitters:F3}");
        }
    }
}
