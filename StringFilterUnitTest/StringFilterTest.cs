using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringConsole.Source;
using StringConsole.Test;

namespace StringFilterUnitTest
{
    [TestClass]
    public class StringFilterTest
    {
        [TestMethod]
        public void SixLetterStrings()
        {
            var strings = SampleStringsStub.Strings();

            var result = StringFilter.SixLetterStrings(strings);

            Assert.AreEqual("albums", result.ElementAt(0));
            Assert.AreEqual("barely", result.ElementAt(1));
        }


        [TestMethod]
        public void SmallLettersStrings()
        {
            var strings = SampleStringsStub.Strings();

            var result = StringFilter.SmallLettersStrings(strings);

            Assert.AreEqual("al", result.ElementAt(0));
            Assert.AreEqual("aver", result.ElementAt(1));
            Assert.AreEqual("bar", result.ElementAt(2));
        }


        [TestMethod]
        [ExpectedException(typeof(Exception),
            "Input strings should not be empty. Please provide an input.")]
        public void NotAllowEmptyInputStrings()
        {
            var strings = new List<string>();
            var result = StringFilter.SixLetterStringsStartWithSmallLetterStrings(strings);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),
            "Only six letter strings available in the input. Needs to have at least one small string which is not six letters.")]
        public void NotAllowOnlySixLetterStrings()
        {
            var strings = SampleStringsStub.OnlySixLetterStrings();
            var result = StringFilter.SixLetterStringsStartWithSmallLetterStrings(strings);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),
            "Only small letters strings available in the input. Needs to have at least one six-letter strings.")]
        public void NotAllowOnlySmallLetterStrings()
        {
            var strings = SampleStringsStub.OnlySmallLetterStrings();
            var result = StringFilter.SixLetterStringsStartWithSmallLetterStrings(strings);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Please enter a valid input string")]
        public void NotAllowNullInput()
        {
          var result = StringFilter.SixLetterStringsStartWithSmallLetterStrings(null);
        }

        [TestMethod]
        public void NotTooMuchTimeForLargeInputStrings()
        {
            var strings = SampleStringsStub.LargeInputStrings();

            var result =
                StringFilter.SixLetterStringsStartWithSmallLetterStrings(strings);

            Assert.AreEqual("albums", result.ElementAt(0));
            Assert.AreEqual("barely", result.ElementAt(1));
            Assert.AreEqual("befoul", result.ElementAt(2));
            Assert.AreEqual("convex", result.ElementAt(3));
            Assert.AreEqual("hereby", result.ElementAt(4));
            Assert.AreEqual("jigsaw", result.ElementAt(5));
            Assert.AreEqual("tailor", result.ElementAt(6));
            Assert.AreEqual("weaver", result.ElementAt(7));
        }


        [TestMethod]
        public void SixLetterStringsStartWithSmallLetterStrings()
        {
            var strings = SampleStringsStub.Strings();

            var result =
                StringFilter.SixLetterStringsStartWithSmallLetterStrings(strings);

            Assert.AreEqual("albums", result.ElementAt(0));
            Assert.AreEqual("barely", result.ElementAt(1));
            Assert.AreEqual("befoul", result.ElementAt(2));
            Assert.AreEqual("convex", result.ElementAt(3));
            Assert.AreEqual("hereby", result.ElementAt(4));
            Assert.AreEqual("jigsaw", result.ElementAt(5));
            Assert.AreEqual("tailor", result.ElementAt(6));
            Assert.AreEqual("weaver", result.ElementAt(7));
        }

        [TestMethod]
        public void RemoveDuplicateSixLetterStrings()
        {
            var strings = SampleStringsStub.DuplicateSixLetterStrings();

            var result = StringFilter.SixLetterStrings(strings);

            Assert.IsTrue(result.Count == 2);
            Assert.AreEqual("albums", result.ElementAt(0));
            Assert.AreEqual("barely", result.ElementAt(1));
        }

        [TestMethod]
        public void RemoveStringsLargerThanSixLetters()
        {
            var strings = SampleStringsStub.LargerThanSixLetterStrings();

            var result = StringFilter.SixLetterStrings(strings);

            Assert.IsTrue(result.Count == 8);
            Assert.AreEqual("albums", result.ElementAt(0));
            Assert.AreEqual("barely", result.ElementAt(1));
            Assert.AreEqual("befoul", result.ElementAt(2));
            Assert.AreEqual("convex", result.ElementAt(3));
            Assert.AreEqual("hereby", result.ElementAt(4));
            Assert.AreEqual("jigsaw", result.ElementAt(5));
            Assert.AreEqual("tailor", result.ElementAt(6));
            Assert.AreEqual("weaver", result.ElementAt(7));
        }

        [TestMethod]
        public void RemoveDuplicateSmallLetterStrings()
        {
            var strings = SampleStringsStub.DuplicateSmallLetterStrings();

            var result = StringFilter.SmallLettersStrings(strings);

            Assert.IsTrue(result.Count == 2);
            Assert.AreEqual("al", result.ElementAt(0));
            Assert.AreEqual("bar", result.ElementAt(1));
        }
    }
}
