using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingInvestment
{
    class Program
    {
        static void Main(string[] args)
        {
            string contract = Console.ReadLine();
            string type = Console.ReadLine();
            double price = 0;
            if (contract == "one")
            {
                switch (type)
                {
                    case "Small": price = 9.98;
                        break;
                    case "Middle": price = 18.99;
                        break;
                    case "Large": price = 25.98;
                        break;
                    case "ExtraLarge": price = 35.99;
                        break;
                    default:
                        break;                  
                }
            }
            else if (contract == "two")
            {
                switch (type)
                {
                    case "Small":
                        price = 8.58;
                        break;
                    case "Middle":
                        price = 17.09;
                        break;
                    case "Large":
                        price = 23.59;
                        break;
                    case "ExtraLarge":
                        price = 31.79;
                        break;
                    default:
                        break;
                }
            }
            string desert = Console.ReadLine();
            double discount = 0;
            if (desert == "yes")
            {
                if (price<=10.00)
                {
                    price = price + 5.50;
                }
                else if (price <= 30.00)
                {
                    price = price + 4.35;
                }
                else if (price > 30.00)
                {
                    price = price + 3.85;
                }               
            }
            if (contract == "two")
            {
                discount = price * 0.0375;
            }
            int mounts = int.Parse(Console.ReadLine());
            double total = (price - discount)*mounts;           
            Console.WriteLine($"{total:F2} lv.");                
        }
    }
}
