using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double waterLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double champagneLiters = double.Parse(Console.ReadLine());
            double whiskeyLiters = double.Parse(Console.ReadLine());
            double champagnePrice = whiskeyPrice * 0.5;
            double winePrice = champagnePrice * 0.4;
            double waterPrice = champagnePrice * 0.1;
            double totalChampagne = champagneLiters * champagnePrice;
            double totalWine = wineLiters * winePrice;
            double totalWater = waterLiters * waterPrice;
            double totalWhiskey = whiskeyLiters * whiskeyPrice;

            double total = totalChampagne + totalWine + totalWater + totalWhiskey;
            Console.WriteLine($"{total:F2}");


        }
    }
}
