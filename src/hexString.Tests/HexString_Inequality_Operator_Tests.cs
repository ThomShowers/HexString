using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hexString.Tests {

    [TestClass]
    public class HexString_Inequality_Operator_Tests {

        [TestMethod]
        public void Inquality_Operator_Returns_True_For_Inequal_Valued_Instances() {
            var hexStringA = new HexString("face");
            var hexStringB = new HexString("fade");
            Assert.IsTrue(hexStringA != hexStringB);
        }

        [TestMethod]
        public void Inequality_Operator_Returns_False_For_Equal_Valued_Instances() {
            var hexStringA = new HexString("face");
            var hexStringB = new HexString("face");
            Assert.IsFalse(hexStringA != hexStringB);
        }

        [TestMethod]
        public void Inequality_Operator_Equates_Two_Nulls() {
            Assert.IsFalse((null as HexString) != (null as HexString));
        }

        [TestMethod]
        public void Inequality_Operator_Handles_Null_Left() {
            var hexString = new HexString("face");
            Assert.IsTrue((null as HexString) != hexString);
        }

        [TestMethod]
        public void Inequality_Operator_Handles_Null_Right() {
            var hexString = new HexString("face");
            Assert.IsTrue(hexString != (null as HexString));
        }
    }
}
