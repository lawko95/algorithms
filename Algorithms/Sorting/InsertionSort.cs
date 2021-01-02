using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    static class InsertionSort
    {
        public static void InsertionSortConsoleProgram()
        {
            Console.WriteLine("This program will sort lists using the insertion sort algorithm");
            bool hasExited = false;
            while (!hasExited)
            {
                Console.WriteLine("Enter 's' to sort a list of strings");
                Console.WriteLine("Enter 'i' to sort a list of integers");
                Console.WriteLine("Enter 'x' to exit the application");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "i":
                        int[] ints = new int[] { 2, 3, 15, 4, 1, 8, 13, 23, 57, 5, 8, 11, 3 };
                        Console.Write("Unsorted integers: ");
                        foreach (int i in ints)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();

                        Sort(ints, decreasing:true);
                        Console.Write("Sorted integers in descending order: ");
                        foreach (int i in ints)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                        break;
                    case "s":
                        string[] strings = new string[] { "als", "ik", "boven", "op", "de", "dom", "sta", "kijk", "ik" };
                        Console.Write("Unsorted strings: ");
                        foreach (string s in strings)
                        {
                            Console.Write(s + " ");
                        }
                        Console.WriteLine();

                        Sort(strings);
                        Console.Write("Sorted strings: ");
                        foreach (string s in strings)
                        {
                            Console.Write(s + " ");
                        }
                        Console.WriteLine();
                        break;
                    case "x":
                        Console.WriteLine("Exiting the application");
                        hasExited = true;
                        break;
                    default:
                        Console.WriteLine("The command was unclear, please try again");
                        break;
                }
            }
        }

        // Int implementation (with optional decreasing parameter)
        static void Sort(int[] array, bool decreasing = false)
        {
            bool ordering(int a, int b)
            {
                if (decreasing)
                {
                    return a > b;
                }
                return a < b;
            }

            for (int i = 0; i < array.Length; i++)
            {
                int pos = i;
                while (pos > 0 && ordering(array[pos], array[pos - 1]))
                {
                    int temp = array[pos - 1];
                    array[pos - 1] = array[pos];
                    array[pos] = temp;
                    pos--;
                }
            }
        }

        // Slightly altered implementation for Strings
        static void Sort(string[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                string key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j].CompareTo(key) == 1)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }

        // Generic implementation
        static void Sort<T>(T[] array) where T : IComparable<T>, IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j].CompareTo(key) == 1)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }
    }
}
