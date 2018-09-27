using Algorithms.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AlgorithmsTests.String
{
    [TestClass]
    public class ReverseWordsTests
    {
        [TestMethod]
        public void ReverseWordsInStringTest()
        {
            var reverseWords = new ReverseWords();

            var input = "Hello, world";
            var expected = "olleH, dlrow";
            var buffer = input.ToCharArray();
            reverseWords.ReverseWordsInString(buffer);
            CollectionAssert.AreEqual(expected.ToCharArray(), buffer);

            input = " hello-World";
            expected = " olleh-dlroW";
            buffer = input.ToCharArray();
            reverseWords.ReverseWordsInString(buffer);
            CollectionAssert.AreEqual(expected.ToCharArray(), buffer);


            input = "hello-World ";
            expected = "olleh-dlroW ";
            buffer = input.ToCharArray();
            reverseWords.ReverseWordsInString(buffer);
            CollectionAssert.AreEqual(expected.ToCharArray(), buffer);

            input = " he ll o ";
            expected = " eh ll o ";
            buffer = input.ToCharArray();
            reverseWords.ReverseWordsInString(buffer);
            CollectionAssert.AreEqual(expected.ToCharArray(), buffer);

            input = "An0ther s3nt3nce.";
            expected = "reht0nA ecn3tn3s.";
            buffer = input.ToCharArray();
            reverseWords.ReverseWordsInString(buffer);
            CollectionAssert.AreEqual(expected.ToCharArray(), buffer);

            input = "a";
            expected = "a";
            buffer = input.ToCharArray();
            reverseWords.ReverseWordsInString(buffer);
            CollectionAssert.AreEqual(expected.ToCharArray(), buffer);

            input = "  ";
            expected = "  ";
            buffer = input.ToCharArray();
            reverseWords.ReverseWordsInString(buffer);
            CollectionAssert.AreEqual(expected.ToCharArray(), buffer);

            input = "";
            expected = "";
            buffer = input.ToCharArray();
            reverseWords.ReverseWordsInString(buffer);
            CollectionAssert.AreEqual(expected.ToCharArray(), buffer);
        }
    }
}
