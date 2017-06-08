using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hexString.Tests {

    [TestClass]
    public class HexString_IsHexadecimalCharacter_Tests {

        [TestMethod]
        public void Correctly_Indentifies_Non_Hex_Characters() {
            foreach (var character in CharacterClasses.NonHexadecimalCharacters) {
                Assert.IsFalse(HexString.IsHexadecimalCharacter(character));
            }
        }

        [TestMethod]
        public void Correctly_Indentifies_Hex_Characters() {
            foreach (var character in CharacterClasses.AllHexadecimalCharacters) {
                Assert.IsTrue(HexString.IsHexadecimalCharacter(character));
            }
        }
    }
}
