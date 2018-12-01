using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a method that finds how many times certain number can be found in a given array.
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} was found {1} times.", number, CountNumber(number, arr));
            Console.ReadLine();
        }
        static int CountNumber(int number, int[] arr)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i++) if (number == arr[i]) counter++;

            return counter;
        }
    }
}
