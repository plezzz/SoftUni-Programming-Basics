using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int table = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double widht = double.Parse(Console.ReadLine());
            double area1 = table * (length + 2 * 0.30) * (widht + 2 * 0.30);
            double area2 = table * (length / 2) * (length / 2);
            double dollar = area1 * 7 + area2 * 9;
            double lev = dollar * 1.85;
            Console.WriteLine("{0:F2} USD", dollar);
            Console.WriteLine("{0:F2} BGN", lev);
        }
    }
}
