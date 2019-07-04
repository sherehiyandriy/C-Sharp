using System;

namespace Algorithms.Search
{
    public class LinearSearcher<T> : ISearcher<T>
    {
        /// <summary>
        /// Finds first item in array that satisfies specified term
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </summary>
        /// <param name="data">Array to search in</param>
        /// <param name="term">Term to check against</param>
        /// <returns>First item that satisfies term</returns>
        public T Find(T[] data, Func<T, bool> term)
        {
            for (var i = 0; i < data.Length; i++)
            {
                if (term(data[i]))
                {
                    return data[i];
                }
            }
            throw new ItemNotFoundException();
        }

        /// <summary>
        /// Finds index of first item in array that satisfies specified term
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </summary>
        /// <param name="data">Array to search in</param>
        /// <param name="term">Term to check against</param>
        /// <returns>Index of first item that satisfies term or -1 if none found</returns>
        public int FindIndex(T[] data, Func<T, bool> term)
        {
            for (var i = 0; i < data.Length; i++)
            {
                if (term(data[i]))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
