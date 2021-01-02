using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class MergeSort
    {
        /// <summary>
        /// Generic merge sort for an array of any type that implements IComparable{T}
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static T[] Sort<T>(T[] array) where T: IComparable<T>
        {
            if (array.Length <= 1)
            {
                return array;
            } 
            else
            {
                int half = array.Length / 2;

                T[] left = new T[half];
                for (int i = 0; i < left.Length; i++)
                {
                    left[i] = array[i];
                }

                T[] right = new T[half + array.Length % 2];
                for (int i = 0; i < right.Length; i++)
                {
                    right[i] = array[half + i];
                }

                // We pass in the original array to the Combine function so that itself actually gets sorted instead of returning a new array
                array = Combine(Sort(left), Sort(right), array);
                return array;
            }
        }

        private static T[] Combine<T>(T[] left, T[] right, T[] combined) where T: IComparable<T>
        {
            int lCount = 0;
            int rCount = 0;
            for (int i = 0; i < combined.Length; i++)
            {
                if (lCount < left.Length && (rCount >= right.Length || left[lCount].CompareTo(right[rCount]) == -1))
                {
                    combined[i] = left[lCount];
                    lCount++;
                }
                else
                {
                    combined[i] = right[rCount];
                    rCount++;
                }
            }
            return combined;
        }

        /// <summary>
        /// Sorts an integer array using the merge sort algorithm
        /// Calls helper function <see cref="InArraySort(int[], int, int)"/>
        /// </summary>
        /// <param name="ints"></param>
        public static void InArraySort(int[] ints)
        {
            InArraySort(ints, 0, ints.Length - 1);
        }

        // Both start and end are inclusive
        public static void InArraySort(int[] ints, int start, int end)
        {
            // An array with 1 or less items is already sorted
            if (start >= end)
            {
                return;
            }

            int half = (start + end) / 2;
            InArraySort(ints, start, half);
            InArraySort(ints, half + 1, end);
            Merge(ints, start, half, end);
        }

        private static void Merge(int[] ints, int leftStart, int middle, int rightEnd)
        {
            int[] left = new int[middle - leftStart + 2];
            int[] right = new int[rightEnd - middle + 1];

            for (int i = 0; i < left.Length - 1; i++)
            {
                left[i] = ints[leftStart + i];
            }
            left[left.Length - 1] = int.MaxValue;

            for (int i = 0; i < right.Length - 1; i++)
            {
                right[i] = ints[middle + 1 + i];
            }
            right[right.Length - 1] = int.MaxValue;

            int leftCount = 0;
            int rightCount = 0;

            // As rightEnd is inclusive, add 1
            for (int i = 0; i < rightEnd + 1 - leftStart; i++)
            {
                if (left[leftCount] < right[rightCount])
                {
                    ints[leftStart + i] = left[leftCount];
                    leftCount++;
                } else
                {
                    ints[leftStart + i] = right[rightCount];
                    rightCount++;
                }
            }
        }
    }
}
