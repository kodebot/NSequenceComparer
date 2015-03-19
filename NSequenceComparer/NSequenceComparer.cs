using System;
using System.Collections.Generic;
using System.Linq;

namespace NSequenceComparer
{
    public static class NSequenceComparer
    {

        public static IEnumerable<T> GetLongestCommonSubsequence<T>(IEnumerable<T> firstSequence, IEnumerable<T> secondSequence)
        {
            return NSequenceComparerInternal<T>.GetLongestCommonSubsequence(firstSequence.ToList(), secondSequence.ToList()).AsEnumerable();
        }

        
        public static IEnumerable<Difference<T>> GetDifferences<T>(IEnumerable<T> firstSequence, IEnumerable<T> secondSequnece)
        {
            return NSequenceComparerInternal<T>.GetDifferences(firstSequence.ToList(), secondSequnece.ToList()).AsEnumerable();
        }

        public static bool AreEqual<T>(IEnumerable<T> firstSequence, IEnumerable<T> secondSequnece)
        {
            throw new NotImplementedException();
        }

    }
}
