using System;
namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = new int[] { 1, 2, 3, 18, 32, 55, 34, 89, 15, 23, 41, 6, 18, 23 };
            //int[] integers = new int[] { 4, 18, 11, 7, 13, 6, 3, 1, 9 };
            MergeSort.Sort(integers);
            //MergeSort.InArraySort(integers);
            Console.WriteLine(BinarySearch.Search(integers, 89));
            //SelectionSort.Sort(integers);
            foreach (int i in integers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            string[] strings = new string[] { "als", "ik", "boven", "op", "de", "dom", "sta", "kijk", "ik" };
            MergeSort.Sort(strings);
            //SelectionSort.Sort(strings);
            foreach (string s in strings)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            int[] AddedNumber = BinaryAddition.Add(new int[] { 1, 0, 0, 1, 0, 1 }, new int[] { 1, 1, 0, 0, 1, 1 });
            foreach (int i in AddedNumber)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            LinearSearch ls = new LinearSearch();
            ls.Search();

            InsertionSort.InsertionSortConsoleProgram();
        }
    }
}
       