using System;

namespace softUniFundExamPrep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();
            int shotCount = 0;
            while(command != "End")
            {
                int index = int.Parse(command);
                if(index >= 0 && index < targets.Count && targets[index] != -1)
                {
                    for(int i = 0; i < targets.Count; i++)
                    {
                        if(i != index && targets[i] != -1)
                        {
                            if(targets[i] > targets[index]) targets[i] -= targets[index];
                            else targets[i] += targets[index];
                        }
                    }
                    targets[index] = -1;
                    shotCount++;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {shotCount} -> {string.Join(' ', targets)}");
        }
    }
}