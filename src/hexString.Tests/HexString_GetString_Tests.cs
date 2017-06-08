using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hexString.Tests {

    [TestClass]
    public class HexString_GetString_Tests {

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throws_ArgumentNullException_For_Null_Array() {
            HexString.GetString(null);
        }

        [TestMethod]
        public void Returns_Correct_HexString_For_Bytes() {
            var expectedString = "000102030405060708090A0B0C0D0E0F";
            var actualString = 
                HexString.GetString(
                    new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });
            Assert.AreEqual(expectedString, actualString);
        }
    }
}
