using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hexString.Tests {

    [TestClass]
    public class HexString_Equality_Operator_Tests {

        [TestMethod]
        public void Equality_Operator_Returns_False_For_Inequal_Valued_Instances() {
            var hexStringA = new HexString("face");
            var hexStringB = new HexString("fade");
            Assert.IsFalse(hexStringA == hexStringB);
        }

        [TestMethod]
        public void Equality_Operator_Returns_True_For_Equal_Valued_Instances() {
            var hexStringA = new HexString("face");
            var hexStringB = new HexString("face");
            Assert.IsTrue(hexStringA == hexStringB);
        }

        [TestMethod]
        public void Equality_Operator_Equates_Two_Nulls() {
            Assert.IsTrue((null as HexString) == (null as HexString));
        }

        [TestMethod]
        public void Equality_Operator_Handles_Null_Left() {
            var hexString = new HexString("face");
            Assert.IsFalse((null as HexString) == hexString);
        }

        [TestMethod]
        public void Equality_Operator_Handles_Null_Right() {
            var hexString = new HexString("face");
            Assert.IsFalse(hexString == (null as HexString));
        }
    }
}
