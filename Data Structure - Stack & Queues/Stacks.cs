using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Stack___Queues
{
    public class Stacks
    {
        public static void StackOperations()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            Console.WriteLine("Stack elemenst are\n");
            foreach(int element in myStack)
                Console.Write(element+" ");
        }

        public static void StackFromArray()
        {
            Console.WriteLine("\n************************");
            int[] arr = new int[] { 1,2,3,4 };
            Stack<int> myStack = new Stack<int>(arr);
            Console.WriteLine("Stack elemenst from array are\n");
            foreach (int element in myStack)
            {
                Console.Write($"{element} ");
            }
        }
       
       
    }
}
