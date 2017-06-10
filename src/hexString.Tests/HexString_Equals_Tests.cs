using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hexString.Tests {

    [TestClass]
    public class HexString_Equals_Tests {

        [TestMethod]
        public void Equals_Returns_False_For_Null_Object() {
            var hexString = new HexString("");
            Assert.IsFalse(hexString.Equals(null));
        }

        [TestMethod]
        public void Equals_Returns_False_For_Non_HexString_Object() {
            var hexString = new HexString("face");
            Assert.IsFalse(hexString.Equals(1234));
        }

        [TestMethod]
        public void Equals_Returns_False_For_Null_HexString() {
            var hexString = new HexString("face");
            Assert.IsFalse(hexString.Equals(null as HexString));
        }

        [TestMethod]
        public void Equals_Returns_False_For_Inequal_HexString() {
            var hexString = new HexString("face");
            Assert.IsFalse(hexString.Equals(new HexString("fade")));
        }

        [TestMethod]
        public void Equals_Returns_True_For_Equal_HexString() {
            var hexString = new HexString("face");
            Assert.IsTrue(hexString.Equals(new HexString("face")));
        }
    }
}
