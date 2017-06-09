using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hexString.Tests {

    [TestClass]
    public class HexString_Cast_Tests {

        [TestMethod]
        public void HexString_Can_Be_Cast_To_Byte_Array() {
            var expectedBytes = 
                new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var hexString = new HexString(expectedBytes);
            byte[] actualBytes = hexString;
            Assert.IsTrue(expectedBytes.SequenceEqual(actualBytes));
        }

        [TestMethod]
        public void HexString_Can_Be_Cast_To_String() {
            var expectedString = "000102030405060708090a0b0c0d0e0f";
            var hexString = new HexString(expectedString);
            string actualString = hexString;
            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void Byte_Array_Can_Be_Cast_To_HexString() {
            var expectedBytes = 
                new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            HexString hexString = expectedBytes;
            var actualBytes = hexString.ToBytes();
            Assert.IsTrue(expectedBytes.SequenceEqual(actualBytes));
        }
    }
}
