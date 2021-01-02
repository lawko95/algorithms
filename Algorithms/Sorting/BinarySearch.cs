using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    static class BinarySearch
    {
        /// <summary>
        /// Performs binary search on an array, calls helper function <see cref="Search{T}(T[], T, int, int)"/>
        /// </summary>
        /// <typeparam name="T">Must implement <see cref="IComparable"/> and <see cref="IComparable{T}"/></typeparam>
        /// <param name="array">The array to search in</param>
        /// <param name="item">The item to search for</param>
        /// <returns>The index of the item searched for</returns>
        public static int Search<T>(T[] array, T item) where T : IComparable, IComparable<T>
        {
            return Search(array, item, 0, array.Length);
        }

        /// <summary>
        /// Returns the index of the item in the array between start (inclusive) and finish (exclusive).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="item"></param>
        /// <param name="start">inclusive</param>
        /// <param name="finish">exclusive</param>
        /// <returns>The index of the item searched for</returns>
        public static int Search<T>(T[] array, T item, int start, int finish) where T : IComparable, IComparable<T>
        {
            // The item is in the start index if this is true as the finish index is exclusive
            if (finish - start <= 1)
            {
                return start;
            }

            // If the item you are looking for is smaller than the item halfway, continue searching in the left side
            int half = (finish + start) / 2;
            if (item.CompareTo(array[half]) == -1)
            {
                return Search(array, item, start, half);
            }

            // Otherwise continue searching in the right side
            return Search(array, item, half, finish);
            
        }
    }
}
