using System;
using System.Collections.Generic;
using System.Linq;

namespace NSequenceComparer
{
    internal static class NSequenceComparerInternal<T>
    {
        internal static List<T> GetLongestCommonSubsequence(IEnumerable<T> firstSequence, IEnumerable<T> secondSequence)
        {
            var firstSequenceCount = firstSequence.Count();
            var secondSequenceCount = secondSequence.Count();
            var result = new List<T>();

            var matrix = new int[firstSequenceCount + 1, secondSequenceCount + 1];

            for (int i = 0; i < firstSequenceCount; i++)
                for (int j = 0; j < secondSequenceCount; j++)
                    if (firstSequence.ElementAt(i).Equals(secondSequence.ElementAt(j)))
                    {
                        matrix[i + 1, j + 1] = matrix[i, j] + 1;
                    }
                    else
                    {
                        matrix[i + 1, j + 1] = Math.Max(matrix[i + 1, j], matrix[i, j + 1]);
                    }


            for (int x = firstSequenceCount, y = secondSequenceCount; x != 0 && y != 0; )
            {
                if (matrix[x, y] == matrix[x - 1, y])
                    x--;
                else if (matrix[x, y] == matrix[x, y - 1])
                    y--;
                else
                {
                    if (firstSequence.ElementAt(x - 1).Equals(secondSequence.ElementAt(y - 1)))
                    {
                        result.Add(firstSequence.ElementAt(x - 1));
                        x--;
                        y--;
                    }
                }
            }
            result.Reverse();
            return result;
        }

        internal static List<Difference<T>> GetDifferences(IEnumerable<T> firstSequence, IEnumerable<T> secondSequnece)
        {
            var differences = new List<Difference<T>>();

            if (firstSequence == null && secondSequnece == null)
            {
                return differences;
            }

            if (firstSequence == null)
            {
                differences.AddRange(secondSequnece.Select(item => new Difference<T>(item, DifferenceKind.Added)));
                return differences;
            }

            if (secondSequnece == null)
            {
                differences.AddRange(firstSequence.Select(item => new Difference<T>(item, DifferenceKind.Deleted)));
                return differences;
            }

            var longestCommonSubSequence = GetLongestCommonSubsequence(firstSequence, secondSequnece);


            var firstSequenceCurrentIndex = 0;
            var firstSequenceLength = firstSequence.Count();
            var secondSequenceCurrentIndex = 0;
            var secondSequenceLength = secondSequnece.Count();

            foreach (var lcsItem in longestCommonSubSequence)
            {
                while (firstSequenceCurrentIndex < firstSequenceLength &&
                    !firstSequence.ElementAt(firstSequenceCurrentIndex).Equals(lcsItem))
                {
                    differences.Add(new Difference<T>(firstSequence.ElementAt(firstSequenceCurrentIndex), DifferenceKind.Deleted));
                    firstSequenceCurrentIndex++;
                }

                while (secondSequenceCurrentIndex < secondSequenceLength &&
                    !secondSequnece.ElementAt(secondSequenceCurrentIndex).Equals(lcsItem))
                {
                    differences.Add(new Difference<T>(secondSequnece.ElementAt(secondSequenceCurrentIndex), DifferenceKind.Added));
                    secondSequenceCurrentIndex++;
                }

                if (firstSequenceCurrentIndex < firstSequenceLength && secondSequenceCurrentIndex < secondSequenceLength)
                {
                    differences.Add(new Difference<T>(lcsItem, DifferenceKind.Unchanged));
                    firstSequenceCurrentIndex++;
                    secondSequenceCurrentIndex++;
                }

            }

            // for items appearing after last element in LCS
            while (firstSequenceCurrentIndex < firstSequenceLength)
            {
                differences.Add(new Difference<T>(firstSequence.ElementAt(firstSequenceCurrentIndex), DifferenceKind.Deleted));
                firstSequenceCurrentIndex++;
            }

            while (secondSequenceCurrentIndex < secondSequenceLength)
            {
                differences.Add(new Difference<T>(secondSequnece.ElementAt(secondSequenceCurrentIndex), DifferenceKind.Added));
                secondSequenceCurrentIndex++;
            }

            return differences;
        }

    }
}
