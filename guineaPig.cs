using System;

namespace softUniFundExamPrep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foodQuantity = Input();
            double hayQuantity = Input();
            double coverQuantity = Input();
            double guineaPigWeight = Input();

            for(int i = 1; i <= 30; i++)
            {
                foodQuantity -= 300;
                if(foodQuantity <= 0) break;

                if(i % 2 == 0) hayQuantity -= 5.00 / 100 * foodQuantity;
                if(hayQuantity <= 0) break;

                if(i % 3 == 0) coverQuantity -= guineaPigWeight / 3.00;
                if(coverQuantity <= 0) break;
            }

            if(foodQuantity > 0 && hayQuantity > 0 && coverQuantity > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! " +
                    $"Food: {foodQuantity / 1000.0:f2}, Hay: {hayQuantity / 1000.0:f2}, Cover: {coverQuantity / 1000.0:f2}.");
            }
            else Console.WriteLine("Merry must go to the pet store!");
        }

        static double Input()
        {
            return double.Parse(Console.ReadLine()) * 1000;
        }
    }
}