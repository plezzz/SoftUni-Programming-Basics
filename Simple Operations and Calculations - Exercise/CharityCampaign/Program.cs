using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int cook = int.Parse(Console.ReadLine());
            int cake = int.Parse(Console.ReadLine());
            int wafer = int.Parse(Console.ReadLine());
            int pancake = int.Parse(Console.ReadLine());
            int cakePrice = cake * 45;
            double waferPrice = wafer * 5.80;
            double pancakePrice = pancake * 3.20;
            double price = (cakePrice + waferPrice + pancakePrice) * day;
            double allPrice = price * cook;
            Console.WriteLine("{0:F2}", allPrice - (allPrice / 8));
        }
    }
}