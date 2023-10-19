using System;

namespace softUniFundExamPrep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('!').ToList();

            string command = Console.ReadLine();
            while(command != "Go Shopping!")
            {
                string[] commandParts = command.Split(' ').ToArray();
                string commandType = commandParts[0];
                switch(commandType)
                {
                    case "Urgent":
                        string urgentItem = commandParts[1];
                        items = Urgent(items, urgentItem);
                        break;
                    case "Unnecessary":
                        string unnecessaryItem = commandParts[1];
                        items = Unnecessary(items, unnecessaryItem);
                        break;
                    case "Correct":
                        string oldItem = commandParts[1];
                        string newItem = commandParts[2];
                        items = Correct(items, oldItem, newItem);
                        break;
                    case "Rearrange":
                        string rearrangableItem = commandParts[1];
                        items = Rearrange(items, rearrangableItem);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", items));
        }

        static List<string> Urgent(List<string> items, string urgentItem)
        {
            if(!items.Contains(urgentItem)) items.Insert(0, urgentItem);
            return items;
        }

        static List<string> Unnecessary(List<string> items, string unnecessaryItem)
        {
            if(items.Contains(unnecessaryItem)) items.Remove(unnecessaryItem);
            return items;
        }

        static List<string> Correct(List<string> items, string oldItem, string newItem)
        {
            if(items.Contains(oldItem)) items[items.IndexOf(oldItem)] = newItem;
            return items;
        }

        static List<string> Rearrange(List<string> items, string rearrangableItem)
        {
            if(items.Contains(rearrangableItem))
            {
                items.Remove(rearrangableItem);
                items.Add(rearrangableItem);
            }
            return items;
        }
    }
}