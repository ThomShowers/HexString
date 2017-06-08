using System;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hexString.Tests {

    [TestClass]
    public class HexString_String_Constructor_Tests {

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throws_ArgumentNullException_For_Null_String() {
            new HexString(null as string);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Throws_ArgumentException_For_Invalid_HexString() {
            new HexString("Invalid hex string.");
        }

        [TestMethod]
        public void Accepts_Valid_HexString() {
            new HexString("000102030405060708090a0b0c0d0e0f");
        }
    }
}
