using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Raven.Personal.CommonInterviewProblems.Algorithms;

namespace Raven.Personal.CommonInterviewProblems.Tests
{
    [TestClass]
    public class SubstringImplementationTests
    {
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void WhenTargetIsNull_ThrowsNullArgumentException()
        {
            String s = null;
            s.MySubString(1, 1);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void WhenStartingPositionIsLessThanZero_ThrowsArgumentOutOfRangeException()
        {
            String s = String.Empty;
            s.MySubString(-1, 1);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void WhenStartingPositionIsMoreThanLengthOfTarget_ThrowsArgumentOutOfRangeException()
        {
            String s = "AB";
            s.MySubString(2, 1);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void WhenLengthIsLessThanOne_ThrowsArgumentOutOfRangeException()
        {
            String s = "AB";
            s.MySubString(2, 0);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void WhenStartingPositionPlusLengthIsMoreThanLengthOfTarget_ThrowsArgumentOutOfRangeException()
        {
            String s = "AB";
            s.MySubString(2, 1);
        }

        [TestMethod]
        public void WhenCalledWithEmptyString_AndZeroLength_ReturnEmptyString()
        {
            String target = String.Empty;
            string expected = String.Empty;
            expected = target.MySubString(0, 0);
        }
        [TestMethod]
        public void WhenCalledWithNonEmptyString_AndZeroLength_ReturnsEmptyString()
        {
            String target = "A";
            string expected = String.Empty;
            expected = target.MySubString(0, 0);
        }

        [TestMethod]
        public void WhenCalledWithStringOfLengthOne_AndStartingPosition0_AndLengthEqualsLengthOfTarget_ReturnsReturnsTarget()
        {
            String target = "A";
            string expected = target;
            expected = target.MySubString(0, target.Length-1);
        }
        [TestMethod]
        public void WhenCalledWithStringOfLengthTwo_AndStartingPosition0_AndLengthEqualsLengthOfTarget_ReturnsReturnsTarget()
        {
            String target = "AB";
            string expected = target;
            expected = target.MySubString(0, target.Length - 1);
        }

        [TestMethod]
        public void WhenCalledWithStringOfLengthTwo_AndStartingPosition0_AndLengthEqualsOne_ReturnsFirstChar()
        {
            String target = "AB";
            string expected = "A";
            expected = target.MySubString(0, 1);
        }
        [TestMethod]
        public void WhenCalledWithStringOfLengthTwo_AndStartingPosition1_AndLengthEqualsOne_ReturnsLastChar()
        {
            String target = "AB";
            string expected = "B";
            expected = target.MySubString(1, 1);
        }
    }
}
