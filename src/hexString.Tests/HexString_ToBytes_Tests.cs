using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hexString.Tests {

    [TestClass]
    public class HexString_ToBytes_Tests {

        [TestMethod]
        public void Returns_Correct_String_After_Bytes_Constructor() {
            var expectedBytes = 
                new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var hexString = new HexString(expectedBytes);
            Assert.IsTrue(expectedBytes.SequenceEqual(hexString.ToBytes()));
        }

        [TestMethod]
        public void Returns_Correct_String_After_String_Constructor() {
            var expectedBytes =
                new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var hexString = new HexString("000102030405060708090a0b0c0d0e0f");
            Assert.IsTrue(expectedBytes.SequenceEqual(hexString.ToBytes()));
        }
    }
}
