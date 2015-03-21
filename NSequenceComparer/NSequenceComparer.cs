using System;
using System.Collections.Generic;
using System.Linq;

namespace NSequenceComparer
{
    /// <summary>
    /// This class provide methods to compare two sequences.
    /// </summary>
    public static class NSequenceComparer
    {

        /// <summary>
        /// Gets the longest common subsequence.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="firstSequence">The first sequence.</param>
        /// <param name="secondSequence">The second sequence.</param>
        /// <returns>The longest common subsequence.</returns>
        public static IEnumerable<T> GetLongestCommonSubsequence<T>(IEnumerable<T> firstSequence, IEnumerable<T> secondSequence)
        {
            return NSequenceComparerInternal<T>.GetLongestCommonSubsequence(firstSequence, secondSequence).AsEnumerable();
        }


        /// <summary>
        /// Gets the differences between two sequences.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="firstSequence">The first sequence.</param>
        /// <param name="secondSequnece">The second sequnece.</param>
        /// <returns>The list of differences between two lists.</returns>
        public static IEnumerable<Difference<T>> GetDifferences<T>(IEnumerable<T> firstSequence, IEnumerable<T> secondSequnece)
        {
            return NSequenceComparerInternal<T>.GetDifferences(firstSequence, secondSequnece).AsEnumerable();
        }

        /// <summary>
        /// Ares the equal.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="firstSequence">The first sequence.</param>
        /// <param name="secondSequnece">The second sequnece.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public static bool AreEqual<T>(IEnumerable<T> firstSequence, IEnumerable<T> secondSequnece)
        {
            throw new NotImplementedException();
        }

    }
}
