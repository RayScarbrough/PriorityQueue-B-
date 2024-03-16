using System;
using System.Collections.Generic;
using System.Numerics;

namespace PriorityQueueExample
{
    class Priority
    {
        static void Main(string[] args)
        {
           
            PriorityQueue<string, int> playersQueue = new PriorityQueue<string, int>();

            
            playersQueue.Enqueue("Chris", 1);
            playersQueue.Enqueue("James", 2);
            playersQueue.Enqueue("Mark", 3);
            playersQueue.Enqueue("Ethan", 4);
            playersQueue.Enqueue("Brad", 5);

                     
            Console.WriteLine($"There are {playersQueue.Count} players online.");


            while (playersQueue.TryDequeue(out string player, out int priority))
            {
              
                Console.WriteLine($"\nthe highest ranked player online is: {player}, Rank: {priority}");
                Console.WriteLine($"{player} has gone offline");         
            }

            
            if (playersQueue.Count == 0)
            {
                Console.WriteLine("\nNo players online.");
            }
        }
    }
}