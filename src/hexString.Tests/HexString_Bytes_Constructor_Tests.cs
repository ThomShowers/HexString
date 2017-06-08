using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hexString.Tests {

    [TestClass]
    public class HexString_Bytes_Constructor_Tests {

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throws_ArgumentNullException_For_Null_Bytes() {
            new HexString(null as byte[]);
        }

        [TestMethod]
        public void Accepts_Bytes() {
            new HexString(new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });
        }
    }
}