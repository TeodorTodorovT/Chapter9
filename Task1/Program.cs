using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a method that by given name prints on the console "Hello, !" (for example: "Hello, Peter!" ).

            Console.Write("Enter name: ");
            ReturnName(Console.ReadLine());
            Console.ReadLine();    
        }
        static void ReturnName(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }
    }
}
