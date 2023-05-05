using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Stack___Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the stack and queues");
            Console.WriteLine("Choose the correct option from the below options ");
            Console.WriteLine("1.Stack\n2.Queue");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    //Stacks stacks = new Stacks();

                    Stacks.StackOperations();
                    Stacks.StackFromArray();

                    break;
                default:
                    Console.WriteLine("Choose Valid Option");
                    break;

            }
            Console.ReadLine();

        }
    }
}
