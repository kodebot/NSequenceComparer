using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSequenceComparer;

namespace NSequenceCompare.Tests
{
    /// <summary>
    /// Tests for NSequenceComparer class.
    /// </summary>
    [TestClass]
    public class NSequenceComparerTests
    {

        /// <summary>
        /// Tests for GetLongestCommonSubsequence method.
        /// </summary>
        [TestClass]
        public class TheGetLongestCommonSubsequenceMethod
        {

            [TestMethod]
            public void ReturnsAllIfTheSequencesAreSameForPrimitives()
            {
                // arrange
                var firstSequence = new List<int> { 1, 2, 3 };
                var secondSequence = new List<int> { 1, 2, 3 };

                // act
                var actual = NSequenceComparer.NSequenceComparer.GetLongestCommonSubsequence<int>(firstSequence, secondSequence);

                // assert
                Assert.AreEqual(3, actual.Count());
                Assert.AreEqual(1, actual.ElementAt(0));
                Assert.AreEqual(2, actual.ElementAt(1));
                Assert.AreEqual(3, actual.ElementAt(2));
            }

            [TestMethod]
            public void ReturnsNoneIfTheSequencesAreEntirelyDifferentForPrimitives()
            {
                // arrange
                var firstSequence = new List<int> { 1, 2, 3 };
                var secondSequence = new List<int> { 4, 5, 6 };

                // act
                var actual = NSequenceComparer.NSequenceComparer.GetLongestCommonSubsequence<int>(firstSequence, secondSequence);

                // assert
                Assert.AreEqual(0, actual.Count());
            }

            [TestMethod]
            public void ReturnsMatchingElementsIfTheSequencesAreParialMatchForPrimitives()
            {
                // arrange
                var firstSequence = new List<int> { 4, 2, 3, 6 };
                var secondSequence = new List<int> { 5, 2, 7, 3 };

                // act
                var actual = NSequenceComparer.NSequenceComparer.GetLongestCommonSubsequence<int>(firstSequence, secondSequence);

                // assert
                Assert.AreEqual(2, actual.Count());
                Assert.AreEqual(2, actual.ElementAt(0));
                Assert.AreEqual(3, actual.ElementAt(1));
            }

            [TestMethod]
            public void ReturnsMatchingElementsIfTheSequencesAreParialMatchAndFirstSequenceIsLongerForPrimitives()
            {
                // arrange
                var firstSequence = new List<int> { 4, 2, 3, 9, 13, 6 };
                var secondSequence = new List<int> { 5, 2, 7, 3 };

                // act
                var actual = NSequenceComparer.NSequenceComparer.GetLongestCommonSubsequence<int>(firstSequence, secondSequence);

                // assert
                Assert.AreEqual(2, actual.Count());
                Assert.AreEqual(2, actual.ElementAt(0));
                Assert.AreEqual(3, actual.ElementAt(1));
            }

            [TestMethod]
            public void ReturnsMatchingElementsIfTheSequencesAreParialMatchAndSecondSequenceIsLongerForPrimitives()
            {
                // arrange
                var secondSequence = new List<int> { 4, 2, 3, 9, 13, 6 };
                var firstSequence = new List<int> { 5, 2, 7, 8, 3 };

                // act
                var actual = NSequenceComparer.NSequenceComparer.GetLongestCommonSubsequence<int>(firstSequence, secondSequence);

                // assert
                Assert.AreEqual(2, actual.Count());
                Assert.AreEqual(2, actual.ElementAt(0));
                Assert.AreEqual(3, actual.ElementAt(1));
            }

            [TestMethod]
            public void ReturnsAllIfTheSequencesAreSameForString()
            {
                // arrange
                var firstSequence = new List<string> { "1", "2", "3" };
                var secondSequence = new List<string> { "1", "2", "3" };

                // act
                var actual = NSequenceComparer.NSequenceComparer.GetLongestCommonSubsequence<string>(firstSequence, secondSequence);

                // assert
                Assert.AreEqual(3, actual.Count());
                Assert.AreEqual("1", actual.ElementAt(0));
                Assert.AreEqual("2", actual.ElementAt(1));
                Assert.AreEqual("3", actual.ElementAt(2));
            }

            [TestMethod]
            public void ReturnsNoneIfTheSequencesAreEntirelyDifferentForString()
            {
                // arrange
                var firstSequence = new List<string> { "1", "2", "3" };
                var secondSequence = new List<string> { "4", "5", "6" };

                // act
                var actual = NSequenceComparer.NSequenceComparer.GetLongestCommonSubsequence<string>(firstSequence, secondSequence);

                // assert
                Assert.AreEqual(0, actual.Count());
            }

            [TestMethod]
            public void ReturnsMatchingElementsIfTheSequencesAreParialMatchForString()
            {
                // arrange
                var firstSequence = new List<string> { "4", "2", "3", "6" };
                var secondSequence = new List<string> { "5", "2", "7", "3" };

                // act
                var actual = NSequenceComparer.NSequenceComparer.GetLongestCommonSubsequence<string>(firstSequence, secondSequence);

                // assert
                Assert.AreEqual(2, actual.Count());
                Assert.AreEqual("2", actual.ElementAt(0));
                Assert.AreEqual("3", actual.ElementAt(1));
            }

            [TestMethod]
            public void ReturnsMatchingElementsIfTheSequencesAreParialMatchAndFirstSequenceIsLongerForString()
            {
                // arrange
                var firstSequence = new List<string> { "4", "2", "3", "9", "13", "6" };
                var secondSequence = new List<string> { "5", "2", "7", "3" };

                // act
                var actual = NSequenceComparer.NSequenceComparer.GetLongestCommonSubsequence<string>(firstSequence, secondSequence);

                // assert
                Assert.AreEqual(2, actual.Count());
                Assert.AreEqual("2", actual.ElementAt(0));
                Assert.AreEqual("3", actual.ElementAt(1));
            }

            [TestMethod]
            public void ReturnsMatchingElementsIfTheSequencesAreParialMatchAndSecondSequenceIsLongerForString()
            {
                // arrange
                var secondSequence = new List<string> { "4", "2", "3", "9", "13", "6" };
                var firstSequence = new List<string> { "5", "2", "7", "8", "3" };

                // act
                var actual = NSequenceComparer.NSequenceComparer.GetLongestCommonSubsequence<string>(firstSequence, secondSequence);

                // assert
                Assert.AreEqual(2, actual.Count());
                Assert.AreEqual("2", actual.ElementAt(0));
                Assert.AreEqual("3", actual.ElementAt(1));
            }

        }

        /// <summary>
        /// Tests for the GetDifferences method.
        /// </summary>
        [TestClass]
        public class TheGetDifferencesMethod
        {
            [TestMethod]
            public void ReturnsUnchangedForItemsAppearingInBothSeqeunceWithMatchingSubsequenceForPrimitives()
            {
                // arrange
                var firstSequence = new List<int> { 1, 2 };
                var secondSequence = new List<int> { 1, 2 };

                // act
                var actual = NSequenceComparer.NSequenceComparer.GetDifferences<int>(firstSequence, secondSequence);

                // assert
                Assert.AreEqual(2, actual.Count(item => item.DifferenceKind == DifferenceKind.Unchanged));
                Assert.AreEqual(1, actual.ElementAt(0).Element);
                Assert.AreEqual(DifferenceKind.Unchanged, actual.ElementAt(0).DifferenceKind);
                Assert.AreEqual(2, actual.ElementAt(1).Element);
                Assert.AreEqual(DifferenceKind.Unchanged, actual.ElementAt(1).DifferenceKind);
            }

            [TestMethod]
            public void ReturnsDeletedForItemsAppearingOnlyInFirstSequenceForPrimitives()
            {
                // arrange
                var firstSequence = new List<int> { 1, 2, 9, 4 };
                var secondSequence = new List<int> { 1, 2, 3 };

                // act
                var actual = NSequenceComparer.NSequenceComparer.GetDifferences<int>(firstSequence, secondSequence);

                // assert
                Assert.AreEqual(2, actual.Count(item => item.DifferenceKind == DifferenceKind.Deleted));
                Assert.AreEqual(9, actual.ElementAt(2).Element);
                Assert.AreEqual(DifferenceKind.Deleted, actual.ElementAt(2).DifferenceKind);
                Assert.AreEqual(4, actual.ElementAt(3).Element);
                Assert.AreEqual(DifferenceKind.Deleted, actual.ElementAt(3).DifferenceKind);
            }

            [TestMethod]
            public void ReturnsAddedForItemsAppearingOnlyInSecondSequenceForPrimitives()
            {
                // arrange
                var firstSequence = new List<int> { 1, 2, 3 };
                var secondSequence = new List<int> { 1, 2, 9, 4, 3 };

                // act
                var actual = NSequenceComparer.NSequenceComparer.GetDifferences<int>(firstSequence, secondSequence);

                // assert
                Assert.AreEqual(2, actual.Count(item => item.DifferenceKind == DifferenceKind.Added));
                Assert.AreEqual(9, actual.ElementAt(2).Element);
                Assert.AreEqual(DifferenceKind.Added, actual.ElementAt(2).DifferenceKind);
                Assert.AreEqual(4, actual.ElementAt(3).Element);
                Assert.AreEqual(DifferenceKind.Added, actual.ElementAt(3).DifferenceKind);
            }

            [TestMethod]
            public void ReturnsEmptyWhenBothSequencesAreNull()
            {
                // arrange

                // act
                var actual = NSequenceComparer.NSequenceComparer.GetDifferences<int>(null, null);

                // assert
                Assert.IsFalse(actual.Any());
            }

            [TestMethod]
            public void ReturnsDeletedWhenForAllWhenOnlySecondSequenceIsNull()
            {
                // arrange
                var firstSequence = new List<int> { 1, 2 };

                // act
                var actual = NSequenceComparer.NSequenceComparer.GetDifferences<int>(firstSequence, null);

                // assert
                Assert.IsTrue(actual.All(item => item.DifferenceKind == DifferenceKind.Deleted));
                Assert.AreEqual(1, actual.ElementAt(0).Element);
                Assert.AreEqual(2, actual.ElementAt(1).Element);
            }

            [TestMethod]
            public void ReturnsAddedWhenForAllWhenOnlyFirstSequenceIsNull()
            {
                // arrange
                var secondSequence = new List<int> { 1, 2 };

                // act
                var actual = NSequenceComparer.NSequenceComparer.GetDifferences<int>(null, secondSequence);

                // assert
                Assert.IsTrue(actual.All(item => item.DifferenceKind == DifferenceKind.Added));
                Assert.AreEqual(1, actual.ElementAt(0).Element);
                Assert.AreEqual(2, actual.ElementAt(1).Element);
            }

        }

    }
}
