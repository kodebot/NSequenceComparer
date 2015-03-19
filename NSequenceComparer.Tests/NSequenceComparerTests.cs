using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NSequenceCompare.Tests
{
    [TestClass]
    public class NSequenceComparerTests
    {

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

    }
}
