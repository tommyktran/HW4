using System;
using System.Collections.Generic;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            var codes = new List<String> { "B1", "B2", "B3", "B4", "B5", "B6", "D1", "D2", "D3" };
            var names = new List<String> { "Sausage Biscuit", "Sausage with Egg Biscuit", "Bacon, Egg & Cheese Biscuit",
                "Bacon, Egg & Cheese Bagel", "Hotcakes", "Hotcakes & Sausage", "Coffee", "Soft Drink", "Tea"};
            var prices = new List<double> { 3.5, 4.0, 4.25, 4.5, 3.75, 4.75, 2.5, 1.5, 1.75 };
            double total = 0.0;
            string input = "";
            int inputIndex = 0;
            int quantity = 0;
            int tendered = 0;

            do
            {
                Console.WriteLine("Enter the item code:");
                input = Console.ReadLine();
                if (codes.Contains(input))
                {
                    inputIndex = codes.IndexOf(input);
                    Console.WriteLine("Enter the quantity of " + names[inputIndex] + ": ");
                    quantity = Int32.Parse(Console.ReadLine());
                    total += prices[inputIndex] * quantity;
                } else if (input != "")
                {
                    Console.WriteLine("Invalid input.");
                }
            } while (input != "");

            total *= 1.06;
            Console.WriteLine();
            Console.WriteLine("Total price: " + total);
            Console.WriteLine("Enter amount tendered: ");
            tendered = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Change due: " + (tendered - total));

        }
    }
}
