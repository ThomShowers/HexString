using System;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hexString.Tests {

    [TestClass]
    public class HexString_HexadecimalCharactertToByte_Tests {

        [TestMethod]
        public void Throws_ArgumentException_For_Non_Hex_Characters() {
            foreach (var character in CharacterClasses.NonHexadecimalCharacters) {
                try {
                    HexString.HexadecimalCharacterToByte(character);
                    Assert.Fail(
                        "Expected ArgumentException for HexadecimalCharacterToByte('{0}')", 
                        character);
                } catch (ArgumentException) { }
            }
        }

        [TestMethod]
        public void Correctly_Indentifies_Upper_Hex_Characters() {
            var hexadecimalCharacters = CharacterClasses.UppercaseHexadecimalCharacters.ToArray();
            for (var i = 0; i < hexadecimalCharacters.Length; i += 1) {
                Assert.AreEqual(i, HexString.HexadecimalCharacterToByte(hexadecimalCharacters[i]));
            }
        }

        [TestMethod]
        public void Correctly_Indentifies_Lower_Hex_Characters() {
            var hexadecimalCharacters = CharacterClasses.LowercaseHexadecimalCharacters.ToArray();
            for (var i = 0; i < hexadecimalCharacters.Length; i += 1) {
                Assert.AreEqual(i, HexString.HexadecimalCharacterToByte(hexadecimalCharacters[i]));
            }
        }
    }
}
