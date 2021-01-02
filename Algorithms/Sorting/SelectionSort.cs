using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    static class SelectionSort
    {
        // Selection sort for an array of integers
        public static int[] Sort(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                int smallestValue = ints[i];
                int smallestIndex = i;
                for (int j = i; j < ints.Length; j++)
                {
                    if (ints[j] < smallestValue)
                    {
                        smallestValue = ints[j];
                        smallestIndex = j;
                    }
                }
                int temp = ints[i];
                ints[i] = smallestValue;
                ints[smallestIndex] = temp;
            }
            return ints;
        }

        // Generic selection sort for an array of any type that implements IComparable<T>
        public static T[] Sort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                var smallestValue = array[i];
                int smallestIndex = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j].CompareTo(smallestValue) == -1)
                    {
                        smallestValue = array[j];
                        smallestIndex = j;
                    }
                }
                var temp = array[i];
                array[i] = smallestValue;
                array[smallestIndex] = temp;
            }
            return array;
        }
    }
}
