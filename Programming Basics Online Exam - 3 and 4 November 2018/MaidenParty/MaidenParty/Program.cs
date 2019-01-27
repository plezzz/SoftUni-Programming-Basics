using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double loveMessagePrice = 0.60;
            double waxRosePrice = 7.20;
            double keyHolderPrice = 3.60;
            double cartoonPrice = 18.20;
            double luckSurprisePrice = 22.00;
            double partyPrice = double.Parse(Console.ReadLine());
            int loveMessageQuantity = int.Parse(Console.ReadLine());
            int waxRoseQuantity = int.Parse(Console.ReadLine());
            int keyHolderQuantity = int.Parse(Console.ReadLine());
            int cartoonQuantity = int.Parse(Console.ReadLine());
            int luckSurpriseQuantity = int.Parse(Console.ReadLine());
            int totalQuantity = loveMessageQuantity + waxRoseQuantity + keyHolderQuantity + cartoonQuantity + luckSurpriseQuantity;
            double salesPrice= (loveMessagePrice * loveMessageQuantity) + (waxRosePrice * waxRoseQuantity) + (keyHolderPrice * keyHolderQuantity) + (cartoonPrice * cartoonQuantity) + (luckSurprisePrice * luckSurpriseQuantity);
            double discount = 0;
            if (totalQuantity >= 25)
            {
                discount = salesPrice * 0.35;              
            }
            double totalPrice = salesPrice - discount;
            double hosting = totalPrice * 0.10;
            double profit = totalPrice - hosting; 
            if (profit > partyPrice)
            {
                double leftMoney = profit - partyPrice;
                Console.WriteLine($"Yes! {leftMoney:F2} lv left.");
            }
            else
            {
                double needMoney = partyPrice - profit;
                Console.WriteLine($"Not enough money! {needMoney:F2} lv needed.");
            }          
        }
    }
}