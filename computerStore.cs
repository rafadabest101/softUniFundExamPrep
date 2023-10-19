using System;

namespace softUniFundExamPrep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double totalPriceWithoutTax = 0.0d;
            while(input != "special" && input != "regular")
            {
                double price = double.Parse(input);
                if(price > 0) totalPriceWithoutTax += price;
                else Console.WriteLine("Invalid price!");

                input = Console.ReadLine();
            }
            if(totalPriceWithoutTax == 0) Console.WriteLine("Invalid order!");
            else
            {
                double taxes = 0.20 * totalPriceWithoutTax;
                double totalPriceWithTax = totalPriceWithoutTax + taxes;
                if(input == "special") totalPriceWithTax -= 0.10 * totalPriceWithTax;
                Console.WriteLine($"Congratulations you've just bought a new computer!"
                    + $"\nPrice without taxes: {totalPriceWithoutTax:f2}$"
                    + $"\nTaxes: {taxes:f2}$"
                    + "\n-----------"
                    + $"\nTotal price: {totalPriceWithTax:f2}$");
            }
        }
    }
}