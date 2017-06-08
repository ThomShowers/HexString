using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hexString.Tests {

    [TestClass]
    public class HexString_IsValidHexString_Tests {

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throws_ArgumentNullException_For_Null_String() {
            HexString.IsValidHexString(null);
        }

        [TestMethod]
        public void Correctly_Identifies_Invalid_HexString() {
            Assert.IsFalse(HexString.IsValidHexString("Invalid hex string."));
        }

        [TestMethod]
        public void Correctly_Identifies_Valid_HexString() {
            Assert.IsTrue(HexString.IsValidHexString("0102030405060708090a0b0c0d0e0f"));
        }
    }
}
