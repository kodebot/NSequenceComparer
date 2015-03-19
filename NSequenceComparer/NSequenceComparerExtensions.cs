using System;
using System.Collections.Generic;
using System.Linq;

namespace NSequenceComparer
{
    public static class NSequenceComparerExtensions
    {

        public static IEnumerable<T> GetLongestCommonSubsequence<T>(this IEnumerable<T> firstSequence, IEnumerable<T> secondSequence)
        {
            return NSequenceComparerInternal<T>.GetLongestCommonSubsequence(firstSequence.ToList(), secondSequence.ToList()).AsEnumerable();
        }


        public static IEnumerable<Difference<T>> GetDifferences<T>(this IEnumerable<T> firstSequence, IEnumerable<T> secondSequnece)
        {
            return NSequenceComparerInternal<T>.GetDifferences(firstSequence.ToList(), secondSequnece.ToList()).AsEnumerable();
        }

    }
}
