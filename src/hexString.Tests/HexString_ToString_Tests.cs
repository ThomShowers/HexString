using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hexString.Tests {

    [TestClass]
    public class HexString_ToString_Tests {

        [TestMethod]
        public void Returns_Correct_String_After_Bytes_Constructor() {
            var expectedString = "000102030405060708090a0b0c0d0e0f";
            var hexString = 
                new HexString(new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });
            Assert.AreEqual(expectedString, hexString.ToString(), true);
        }

        [TestMethod]
        public void Returns_Correct_String_After_String_Constructor() {
            var expectedString = "000102030405060708090a0b0c0d0e0f";
            var hexString = new HexString(expectedString);
            Assert.AreEqual(expectedString, hexString.ToString(), true);
        }
    }
}
