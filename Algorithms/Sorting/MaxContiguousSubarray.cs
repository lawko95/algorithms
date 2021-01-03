using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Sorting
{
    public static class MaxContiguousSubarray
    {
        /// <summary>
        /// Returns the value of the maximum contiguous subarray using dynamic programming
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int? DynamicProgramming(int[] array)
        {
            Stopwatch watch = Stopwatch.StartNew();

            if (array == null || array.Length == 0)
                return null;

            int currentValue = array[0];
            int maxValue = int.MinValue;

            int[] subTotals = new int[array.Length];

            for (int i = 1; i < array.Length; i++)
            {
                if (currentValue > 0)
                    currentValue += array[i];
                else
                    currentValue = array[i];

                subTotals[i] = currentValue;

                if (currentValue > maxValue)
                    maxValue = currentValue;
            }

            watch.Stop();
            Console.WriteLine(watch.Elapsed);

            return maxValue;
        }

        /// <summary>
        /// Brute forces the largest rise between two numbers in the array by checking each pair
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (int left, int right, int largestRise)? BruteForce(int[] array)
        {
            Stopwatch watch = Stopwatch.StartNew();

            if (array == null || array.Length <= 1)
            {
                return null;
            }
            int left = 0;
            int right = 0;
            int largestRise = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] - array[i] > largestRise)
                    {
                        largestRise = array[j] - array[i];
                        left = i;
                        right = j;
                    }
                }
            }

            watch.Stop();
            Console.WriteLine(watch.Elapsed);
            return (left, right, largestRise);
        }
        /// <summary>
        /// Returns the value of the maximum contiguous subarray within the passed array combined with
        /// its start index (inclusive) and end index (inclusive) using divide and conquer
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (int left, int right, int sum) DivideAndConquer(int[] array)
        {
            Stopwatch watch = Stopwatch.StartNew();
            var result = DivideAndConquer(array, 0, array.Length - 1);
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
            return result;
        }

        private static (int left, int right, int sum) DivideAndConquer(int[] array, int left, int right)
        {
            if (right - left < 1)
            {
                return (left, right, array[left]);
            }

            int half = (right + left) / 2;
            var maxLeft = DivideAndConquer(array, left, half);
            var maxRight = DivideAndConquer(array, half + 1, right);
            var maxCross = MaxCrossingArray(array, left, half, right);
            return maxLeft.sum > maxRight.sum && maxLeft.sum > maxCross.sum ? maxLeft :
                maxRight.sum > maxCross.sum ? maxRight : maxCross;
        }

        private static (int left, int right, int sum) MaxCrossingArray(int[] array, int left, int half, int right)
        {
            int leftSum = array[half], leftValue = half, sum = 0;
            for (int i = half; i >= left; i--)
            {
                sum += array[i];
                if (sum > leftSum)
                {
                    leftSum = sum;
                    leftValue = i;
                }
            }
            int rightSum = array[half + 1], rightValue = half + 1;
            sum = 0;
            for (int i = half + 1; i <= right; i++)
            {
                sum += array[i];
                if (sum > rightSum)
                {
                    rightSum = sum;
                    rightValue = i;
                }
            }

            return (leftValue, rightValue, leftSum + rightSum);
        }
    }
}
