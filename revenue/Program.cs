using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revenue
{
    class DisRev   // discount and revenue for total price of 5000, there 
    {               // will be a 10% discount
        static void Main(string[] args)
        {
            double price, quantity, revenue, discount, new_price;

            Console.WriteLine("Enter your price:");
            price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your quantity:");
            quantity = Convert.ToDouble(Console.ReadLine());

            revenue = (double)(price * quantity);
            discount = (double)(revenue * 0.10);
            new_price = revenue - discount;

            if (revenue > 5000)
            {
                Console.WriteLine("The discount will be:" + discount);
                Console.WriteLine("The new price will be:" + new_price);
            }
            else Console.WriteLine("There is no discount and the revenue will be:" + revenue);

        }
    }
}
