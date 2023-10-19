using System;

namespace softUniFundExamPrep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine().Split('@').Select(int.Parse).ToList();

            string command = Console.ReadLine();
            int houseIndex = 0;
            int lastPositionIndex = 0;
            while(command != "Love!")
            {
                string[] jumpParts = command.Split(' ').ToArray();
                int jumpLength = int.Parse(jumpParts[1]);
                houseIndex += jumpLength;
                if(houseIndex >= houses.Count) houseIndex = 0;

                if(houses[houseIndex] >= 2)
                {
                    houses[houseIndex] -= 2;
                    if(houses[houseIndex] == 0) Console.WriteLine($"Place {houseIndex} has Valentine's day.");
                }
                else Console.WriteLine($"Place {houseIndex} already had Valentine's day.");

                lastPositionIndex = houseIndex;
                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {lastPositionIndex}.");
            int failedHouses = 0;
            foreach(int hearts in houses)
            {
                if(hearts > 0) failedHouses++;
            }
            if(failedHouses == 0) Console.WriteLine("Mission was successful.");
            else Console.WriteLine($"Cupid has failed {failedHouses} places.");
        }
    }
}