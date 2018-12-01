using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a method that returns the position of the first occurrence of an element from an array, such that it is greater than its two neighbors simultaneously. Otherwise the result must be -1.
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            CompareNumber(arr);

            if (number == int.MinValue) Console.WriteLine("-1");
            else Console.WriteLine("{0} is bigger than it's neighbours", number);
            Console.ReadLine();
        }
        static void CompareNumber(int[] arr)
        {
            for (int i = 1; i < arr.Length - 1; i++)
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    number = arr[i];
                    break;
                }
        }
        static int number = int.MinValue;
    }
}
