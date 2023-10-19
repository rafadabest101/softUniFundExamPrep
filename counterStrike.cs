using System;

namespace softUniFundExamPrep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int wonBattles = 0;
            while(command != "End of battle")
            {
                int distance = int.Parse(command);
                if(energy >= distance)
                {
                    wonBattles++;
                    energy -= distance;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    break;
                }
                if(wonBattles % 3 == 0) energy += wonBattles;
                command = Console.ReadLine();
            }
            if(command == "End of battle") Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
        }
    }
}