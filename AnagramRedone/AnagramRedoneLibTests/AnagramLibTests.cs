using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramRedoneLib;
using System.Reflection;

namespace AnagramRedoneLibTests
{
    [TestClass]
    public class AnagramTests
    {
        [DataTestMethod]
        [DataRow("abcd", "dcba")]
        [DataRow(@"!@#$%^&*(", @"!@#$%^&*(")]
        [DataRow(@"Ab1c!@#d.", @"dc1b!@#A.")]
        public void ReverseWordTest_ReverseInputWord_ShouldReturn_ReversedWord(string source, string expected)
        {
            var anagram = new Anagram();
            var method = typeof(Anagram).GetMethod("ReverseWord", BindingFlags.Instance | BindingFlags.NonPublic);
            var actual = method?.Invoke(anagram, new object[] { source });
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow("abcd efgh", "dcba hgfe")]
        [DataRow("a1bcd efg!h", "d1cba hgf!e")]
        [DataRow(@"\tabcd\tefgh", @"\hgfet\dcbat")]
        [DataRow("     ", "     ")]
        [DataRow("123!", "123!")]
        [DataRow("  A  ", "  A  ")]
        [DataRow("  Abc  ", "  cbA  ")]
        [DataRow("", "")]
        [DataRow(null, null)]
        public void ReversePhraseTest_ReverseTheInputPhrase_ShouldReturn_ReversedPhrase(string source, string expected)
        {
            var anagram = new Anagram();
            string actual = anagram.ReversePhrase(source);
            Assert.AreEqual(expected, actual);
        }


    }
}