using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    /// <summary>
    /// Static class housing bubble sort methods
    /// </summary>
    public static class BubbleSort
    {
        /// <summary>
        /// Sort an array of any type implementing <see cref="IComparable"/> and <see cref="IComparable{T}"/> using the bubble sort algorithm
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void Sort<T>(T[] array) where T: IComparable, IComparable<T>
        {
            for (int i = 0; i < array.Length - 2; i++)
            {
                for (int j = array.Length - 1; j > i ; j--)
                {
                    if (array[j].CompareTo(array[j-1]) == -1)
                    {
                        T temp = array[j];
                        array[j] = array[j-1];
                        array[j-1] = temp;
                    }
                }
            }
        }
    }
}
