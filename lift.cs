using System;

namespace softUniFundExamPrep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int totalPeople = people;
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for(int i = 0; i < wagons.Count; i++)
            {
                totalPeople += wagons[i];
                while(wagons[i] < 4)
                {
                    wagons[i]++;
                    people--;
                    if(people == 0) break;
                }
                if(people == 0) break;
            }

            if(people == 0)
            {
                if(wagons.Count * 4 == totalPeople) Console.WriteLine(string.Join(' ', wagons));
                else
                {
                    Console.WriteLine("The lift has empty spots!");
                    Console.WriteLine(string.Join(' ', wagons));
                }
            }
            else
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(' ', wagons));
            }
        }
    }
}