using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    static class BinaryAddition
    {
        /// <summary>
        /// Assumption that each int within both arrays is either 0 or 1 to simulate adding two numbers stored as bits
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public static int[] Add(int[] first, int[] second)
        {
            int[] answer = new int[first.Length + 1];

            // Condition that the two "binary" numbers being added are of the same size.
            if (first.Length != second.Length)
            {
                return null;
            }

            int remainder = 0;
            int current;

            for (int i = first.Length-1 ; i >= 0; i--)
            {
                current = remainder + first[i] + second[i];
                answer[i + 1] = current % 2;
                remainder = current / 2;
            }
            answer[0] = remainder;

            return answer;
        }
    }
}
