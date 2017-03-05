using System;
using System.Linq;

namespace AK.QuestionsCS
{
    public abstract class BinarySearcherBase : IBinarySearcher
    {
        /// <summary>
        /// Searches an index of specified integer in sorted by ascending array. If there are more then one elements equal to given integer, result index is not determined.
        /// </summary>
        /// <param name="input">Array sorted by ascending</param>
        /// <param name="x">Element which index to find</param>
        /// <returns>Index of 'x' in the array 'input'</returns>
        public int? BinarySearch(int[] input, int x)
        {
            if (!input.Any())
                throw new ApplicationException("There are no elements in the input array");

            if (input[0] > input[input.Length - 1])
                throw new ApplicationException("Array is not sorted by ascending");

            if ((x < input[0]) || (x > input[input.Length - 1]))
                return null;

            return BinarySearchBody(input, x, 0, input.Length);
        }

        protected abstract int? BinarySearchBody(int[] array, int key, int start, int end);
    }
}
