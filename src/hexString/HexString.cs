using System;

namespace hexString {

    /// <summary>
    /// A <see cref="HexString"/> is a convenience type for representing a <see cref="byte"/>
    /// array as a <see cref="string"/>.
    /// </summary>
    public class HexString {

        private static readonly char[] HEXADECIMAL_CHARACTERS =
            "0123456789ABCDEFabcdef".ToCharArray();

        /// <summary>
        /// Determines whether a character is a hexadecimal character. 
        /// </summary>
        /// <param name="character">The character.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="character"/> is a hexadecimal character, otherwse
        /// <c>false</c>.
        /// </returns>
        public static bool IsHexadecimalCharacter(char character) {
            return Array.IndexOf(HEXADECIMAL_CHARACTERS, character) > -1;
        }

        /// <summary>
        /// Gets the value represented by a hexadecimal character.
        /// </summary>
        /// <param name="character">The character.</param>
        /// <returns>The value represented by <paramref name="character"/>.</returns>
        /// <exception cref="ArgumentException">
        /// <paramref name="character"/> is not a hexadecimal character.
        /// </exception>
        public static byte HexadecimalCharacterToByte(char character) {
            var index = Array.IndexOf(HEXADECIMAL_CHARACTERS, char.ToUpper(character));
            if (index == -1) {
                throw new ArgumentException("Must be a valid hexadecimal character.", "character");
            }
            return (byte)index;
        }

        /// <summary>
        /// Determines whether a string is a valid <see cref="HexString"/>. 
        /// </summary>
        /// <param name="stringToValidate">The string.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="stringToValidate"/> is a valid <see cref="HexString"/>,
        /// otherwise <c>false</c>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="stringToValidate"/> is <c>null</c>.
        /// </exception>
        public static bool IsValidHexString(string stringToValidate) {
            if (stringToValidate == null) { throw new ArgumentNullException("stringToValidate"); }
            if (stringToValidate.Length % 2 != 0) {
                return false;
            }
            for (var i = 0; i < stringToValidate.Length; i += 1) {
                if (Array.IndexOf(HEXADECIMAL_CHARACTERS, stringToValidate[i]) == -1) {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Gets the bytes represented by a hexadecimal string. 
        /// </summary>
        /// <param name="hexadecimalString">The string.</param>
        /// <returns>
        /// The bytes that <paramref name="hexadecimalString"/> represents.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="hexadecimalString"/> is <c>null</c>.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="hexadecimalString"/> is not a valid <see cref="HexString"/>. 
        /// </exception> 
        public static byte[] GetBytes(string hexadecimalString) {
            if (hexadecimalString == null) {
                throw new ArgumentNullException("hexadecimalString");
            }
            if (!IsValidHexString(hexadecimalString)) {
                throw new ArgumentException("Must be a valid HexString.", "hexadecimalString");
            }
            var bytes = new byte[hexadecimalString.Length / 2];
            for (var bytesIndex = 0; bytesIndex < bytes.Length; bytesIndex += 1) {
                var stringIndex = bytesIndex * 2;
                var highOrderCharacter = hexadecimalString[stringIndex++];
                var lowOrderCharacter = hexadecimalString[stringIndex];
                var highOrderValue = HexadecimalCharacterToByte(highOrderCharacter);
                var lowOrderValue = HexadecimalCharacterToByte(lowOrderCharacter);
                bytes[bytesIndex] = (byte)((highOrderValue << 4) + lowOrderValue);
            }
            return bytes;
        }

        /// <summary>
        /// Gets the hexadecimal string that represents a byte array.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <returns>The hexadecimal string that represents <paramref name="bytes"/>.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="bytes"/> is <c>null</c>.
        /// </exception>
        public static string GetString(byte[] bytes) {
            if (bytes == null) { throw new ArgumentNullException("bytes"); }
            var chars = new char[bytes.Length * 2];
            for (var bytesIndex = 0; bytesIndex < bytes.Length; bytesIndex += 1) {
                var highOrderValue = bytes[bytesIndex] >> 4;
                var lowOrderValue = bytes[bytesIndex] & 0x0F;
                chars[bytesIndex * 2] = HEXADECIMAL_CHARACTERS[highOrderValue];
                chars[bytesIndex * 2 + 1] = HEXADECIMAL_CHARACTERS[lowOrderValue];
            }
            return new string(chars);
        }
    }
}
