using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hexString.Tests {

    [TestClass]
    public class HexString_GetHashCode_Tests {

        [TestMethod]
        public void Returns_Same_HashCode_For_Equal_Valued_HexStrings() {
            var hexStringA = new HexString("face");
            var hexStringB = new HexString("face");
            Assert.AreEqual(hexStringA.GetHashCode(), hexStringB.GetHashCode());
        }
    }
}
