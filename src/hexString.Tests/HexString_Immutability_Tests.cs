using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hexString.Tests {

    [TestClass]
    public class HexString_Immutability_Tests {

        [TestMethod]
        public void Bytes_Constructor_Argument_Cannot_Mutate() {
            var argument = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var hexString = new HexString(argument);
            argument[0] = 1;
            var bytes = hexString.ToBytes();
            Assert.AreNotEqual(argument[0], bytes[0]);
        }

        [TestMethod]
        public void Bytes_From_ToBytes_Cannot_Mutate() {
            var hexString = 
                new HexString(new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });
            var notExpected = hexString.ToBytes();
            notExpected[0] = 1;
            var expected = hexString.ToBytes();
            Assert.AreNotEqual(notExpected[0], expected[0]);
        }
    }
}
