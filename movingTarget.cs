using System;

namespace softUniFundExamPrep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while(command != "End")
            {
                string[] commandParts = command.Split(' ').ToArray();
                if(commandParts[0] == "Shoot")
                {
                    int index = int.Parse(commandParts[1]);
                    int power = int.Parse(commandParts[2]);
                    targets = Shoot(targets, index, power);
                }
                else if(commandParts[0] == "Add")
                {
                    int index = int.Parse(commandParts[1]);
                    int value = int.Parse(commandParts[2]);
                    targets = Add(targets, index, value);
                }
                else if(commandParts[0] == "Strike")
                {
                    int index = int.Parse(commandParts[1]);
                    int radius = int.Parse(commandParts[2]);
                    targets = Strike(targets, index, radius);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join('|', targets));
        }

        static List<int> Shoot(List<int> targets, int index, int power)
        {
            if(IsValidIndex(index, targets))
            {
                targets[index] -= power;
                if(targets[index] <= 0) targets.Remove(targets[index]);
            }

            return targets;
        }

        static List<int> Add(List<int> targets, int index, int value)
        {
            if(IsValidIndex(index, targets)) targets.Insert(index, value);
            else Console.WriteLine("Invalid placement!");

            return targets;
        }

        static List<int> Strike(List<int> targets, int index, int radius)
        {
            if(IsValidIndex(index + radius, targets) 
                && IsValidIndex(index, targets) 
                && IsValidIndex(index - radius, targets))
            {
                for(int i = index + radius; i >= index - radius; i--)
                {
                    targets.RemoveAt(i);
                }
            }
            else Console.WriteLine("Strike missed!");

            return targets;
        }

        static bool IsValidIndex(int index, List<int> targets)
        {
            return index < targets.Count && index >= 0;
        }
    }
}