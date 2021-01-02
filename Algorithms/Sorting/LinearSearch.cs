using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class LinearSearch
    {
        int[] integers;
        public LinearSearch()
        {
            int[] defaultArray = new int[] { 1, 2, 3, 18, 32, 55, 34, 89, 15, 23, 41, 6, 18, 23 };

            Console.WriteLine("Provide a space separated list of numbers, or just press enter");
            string inputArray = Console.ReadLine();

            if (inputArray == "")
            {
                integers = defaultArray;
            }
            else
            {
                try
                {
                    integers = Array.ConvertAll(inputArray.Split(), int.Parse);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, a default list of numbers is being used instead.");
                    integers = defaultArray;
                }
            }

            Console.Write("The array is: ");
            foreach (int i in integers)
            {
                Console.Write(i + " ");
            }
        }

        public void Search()
        {
            Console.WriteLine("\nType in a number, if it is in the array, we return its index, if not we return NULL");
            int number = int.Parse(Console.ReadLine());

            string answer = "NULL";
            for (int i = 0; i < integers.Length; i++)
            {
                if (number == integers[i])
                {
                    answer = i.ToString();
                    break;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
