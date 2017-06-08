using System;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hexString.Tests {

    [TestClass]
    public class HexString_GetBytes_Tests {

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throws_ArgumentNullException_For_Null_String() {
            HexString.GetBytes(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Throws_ArgumentException_For_Invalid_HexString() {
            HexString.GetBytes("Invalid hex string.");
        }

        [TestMethod]
        public void Returns_Correct_Bytes_For_HexString() {
            var expectedBytes = 
                new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var actualBytes = HexString.GetBytes("000102030405060708090a0b0c0d0e0f");
            Assert.IsTrue(expectedBytes.SequenceEqual(actualBytes));
        }
    }
}
