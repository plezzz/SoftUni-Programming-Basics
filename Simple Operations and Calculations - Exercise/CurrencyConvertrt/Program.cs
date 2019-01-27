using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            string currency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();
            if (currency == "USD" && outputCurrency == "BGN")
            {
                var n = amount * 1.79549;
                Console.WriteLine("BGN:{0}", Math.Round(n, 2));
            }
            else if (currency == "BGN" && outputCurrency == "EUR")
            {
                var n1 = amount / 1.95583;
                Console.WriteLine("EUR:{0}", Math.Round(n1, 2));
            }
            else if (currency == "EUR" && outputCurrency == "GBP")
            {
                var n2 = amount * 0.7716599190283401;
                Console.WriteLine("GBP:{0}", Math.Round(n2, 2));
            }
            else if (currency == "USD" && outputCurrency == "EUR")
            {
                var n3 = amount * 0.9179913535084802;
                Console.WriteLine("EUR:{0}", Math.Round(n3, 2));
            }
            else if (currency == "GBP" && outputCurrency == "USD")
            {
                var n4 = amount * 1.411336032388664;
                Console.WriteLine("USD:{0}", Math.Round(n4, 2));
            }
            else
                Console.WriteLine("Invalid currency");
        }
    }
}
