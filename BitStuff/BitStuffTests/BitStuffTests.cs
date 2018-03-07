using Microsoft.VisualStudio.TestTools.UnitTesting;
using BitStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitStuff.Tests
{
    [TestClass()]
    public class BitStuffTests
    {
        [TestMethod()]
        public void BitCountTest_1()
        {
            Assert.AreEqual(1, BitStuff.BitCount((int)1));
        }

        [TestMethod()]
        public void BitCountTest_100()
        {
            Assert.AreEqual(3, BitStuff.BitCount((int)100));
        }

        [TestMethod()]
        public void BitCountTest_neg1()
        {
            Assert.AreEqual(32, BitStuff.BitCount((int)-1));
        }

        [TestMethod()]
        public void BitCountByteTest_1()
        {
            Assert.AreEqual(1, BitStuff.BitCount((byte)1));
        }

        [TestMethod()]
        public void BitCountByteTest_100()
        {
            Assert.AreEqual(3, BitStuff.BitCount((byte)100));
        }

        [TestMethod()]
        public void ParityControlTest()
        {
            Assert.AreEqual("Ana.", BitStuff.ParityControl("65 238 236 225 46"));
        }
    }
}