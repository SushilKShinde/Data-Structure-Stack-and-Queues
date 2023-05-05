using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Stack___Queues
{
    public class Queues
    {
        public static void QueueOperations()
        {
            Queue<int> queue = new Queue<int>();
            //First In First Out
            //add elements to the queue
            queue.Enqueue(10);             
            queue.Enqueue(20);              
            queue.Enqueue(30);
            queue.Enqueue(40);
            Console.WriteLine("Queue elements are\n");
            foreach(int element in queue)
            {
                Console.Write(element+" ");  //10,20,30,40
            }

            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine("\nQueue elements after dequeue");
            foreach (int element in queue)
            {
                Console.Write(element + " ");  //30,40
            }

            Console.WriteLine($"\nThe peek element of queue is {queue.Peek()}");
        }
    }
}
