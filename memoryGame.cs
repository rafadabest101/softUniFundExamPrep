using System;

namespace softUniFundExamPrep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ').ToList();

            string command = Console.ReadLine();
            int moves = 0;
            while(command != "end")
            {
                moves++;
                int[] indexes = command.Split().Select(int.Parse).ToArray();
                int index1 = indexes[0];
                int index2 = indexes[1];
                if(index1 == index2 || index1 < 0 || index2 < 0 || index1 >= elements.Count || index2 >= elements.Count)
                {
                    elements.Insert(elements.Count / 2, $"-{moves}a");
                    elements.Insert(elements.Count / 2, $"-{moves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if(elements[index1] != elements[index2]) Console.WriteLine("Try again!");
                else if(elements[index1] == elements[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[index1]}!");
                    elements.RemoveAt(Math.Max(index1, index2));
                    elements.RemoveAt(Math.Min(index1, index2));
                }

                if(elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }
                command = Console.ReadLine();
            }
            if(elements.Count != 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(' ', elements));
            }
        }
    }
}