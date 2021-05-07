using System;
namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(5, 5, 2);
            matrix.PrintMatrix();
            Console.WriteLine(matrix.nRows);
            Console.WriteLine(matrix.nCols);


            int[] integers = new int[] { 13, -3, -25, 20, -3, -16, -23, 18, 20, -7, 12, -5, -22, 15, -4, 7 };
            Console.WriteLine(MaxContiguousSubarray.DivideAndConquer(integers));
            Console.WriteLine(MaxContiguousSubarray.DynamicProgramming(integers));

            int[] integers2 = new int[1000];
            Random rnd = new Random();
            for (int i = 0; i < integers2.Length; i++)
                integers2[i] = rnd.Next(-200, 200);

            Console.WriteLine(MaxContiguousSubarray.BruteForce(integers2));
            Console.WriteLine(MaxContiguousSubarray.DivideAndConquer(integers2));
            Console.WriteLine(MaxContiguousSubarray.DynamicProgramming(integers2));
        }
        static void Main2(string[] args)
        {
            Bicycle[] bicycles = new Bicycle[3];
            bicycles[0] = new Bicycle("Steven's Bicycles", System.Drawing.Color.Green, "This is a feisty bike with a bit of zest", 4.9);
            bicycles[1] = new Bicycle("bike two", System.Drawing.Color.Red, "This is a cute bike", 3.2);
            bicycles[2] = new Bicycle("Another bike", System.Drawing.Color.Turquoise, "Bikey McBike Face", 13.8);
            BubbleSort.Sort(bicycles);
            Bicycle.PrintBicycles(bicycles);
             

            int[] integers = new int[] { 1, 2, 3, 18, 32, 55, 34, 89, 15, 23, 41, 6, 18, 23 };
            //int[] integers = new int[] { 4, 18, 11, 7, 13, 6, 3, 1, 9 };
            BubbleSort.Sort(integers);
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
       