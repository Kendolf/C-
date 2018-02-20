using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunLengthEncoding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLengthEncoding.Tests
{
    [TestClass()]
    public class RunLengthEncodingTests
    {
        [TestMethod()]
        public void test_encode_empty_string()
        {
            Assert.AreEqual("", RunLengthEncoding.Encode(""));
        }

        [TestMethod()]
        public void test_encode_single_characters_only_are_encoded_without_count()
        {
            Assert.AreEqual("XYZ", RunLengthEncoding.Encode("XYZ"));
        }

        [TestMethod()]
        public void test_encode_string_with_no_single_characters()
        {
            Assert.AreEqual("2A3B4C", RunLengthEncoding.Encode("AABBBCCCC"));
        }

        [TestMethod()]
        public void test_encode_single_characters_mixed_with_repeated_characters()
        {
            Assert.AreEqual("12WB12W3B24WB", RunLengthEncoding.Encode("WWWWWWWWWWWWBWWWWWWWWWWWWBBBWWWWWWWWWWWWWWWWWWWWWWWWB"));
        }

        [TestMethod()]
        public void test_encode_multiple_whitespace_mixed_in_string()
        {
            Assert.AreEqual("2 hs2q q2w2 ", RunLengthEncoding.Encode("  hsqq qww  "));
        }

        [TestMethod()]
        public void test_encode_lowercase_characters()
        {
            Assert.AreEqual("2a3b4c", RunLengthEncoding.Encode("aabbbcccc"));
        }

        [TestMethod()]
        public void test_decode_empty_string()
        {
            Assert.AreEqual("", RunLengthEncoding.Decode(""));
        }

        [TestMethod()]
        public void test_decode_single_characters_only()
        {
            Assert.AreEqual("XYZ", RunLengthEncoding.Decode("XYZ") );
        }

        [TestMethod()]
        public void test_decode_string_with_no_single_characters()
        {
            Assert.AreEqual("AABBBCCCC", RunLengthEncoding.Decode("2A3B4C") );
        }

        [TestMethod()]
        public void test_decode_single_characters_with_repeated_characters()
        {
            Assert.AreEqual( "WWWWWWWWWWWWBWWWWWWWWWWWWBBBWWWWWWWWWWWWWWWWWWWWWWWWB", RunLengthEncoding.Decode("12WB12W3B24WB"));
        }

        [TestMethod()]
        public void test_decode_multiple_whitespace_mixed_in_string()
        {
            Assert.AreEqual("  hsqq qww  ", RunLengthEncoding.Decode("2 hs2q q2w2 ") );
        }

        [TestMethod()]
        public void test_decode_lower_case_string()
        {
            Assert.AreEqual( "aabbbcccc", RunLengthEncoding.Decode("2a3b4c"));
        }

        [TestMethod()]
        public void test_combination()
        {
            Assert.AreEqual("zzz ZZ  zZ", RunLengthEncoding.Decode(RunLengthEncoding.Encode("zzz ZZ  zZ")));
        }

    }
}