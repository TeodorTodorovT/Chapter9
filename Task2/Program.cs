using System;

namespace Task2
{
    class Program
    {
        static int a;
        static void Main(string[] args)
        {   //task: Create a method GetMax() with two integer (int) parameters, that returns maximal of the two numbers. Write a program that reads three numbers from the console and prints the biggest of them. Use the GetMax() method you just created.
            Console.Write("Enter first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            GetMax(a, b);
            GetMax(a, c);

            Console.WriteLine("Biggest number is {0}", a);
            Console.ReadLine();
        }
        static void GetMax(int first, int second)
        {
            if (first > second) a = first;
            else a = second;
        }
    }
}
