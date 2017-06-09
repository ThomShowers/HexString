using System;
using System.Collections.Generic;
using System.Linq;

namespace hexString.Tests {

    /// <summary>
    /// Enumerates various collections of <see cref="char"/> type values.
    /// </summary>
    internal static class CharacterClasses {

        /// <summary>
        /// Enumerates the lower case hexadecimal characters.
        /// </summary>
        internal static IEnumerable<char> LowercaseHexadecimalCharacters {
            get {
                foreach (var character in "0123456789abcdef".ToCharArray()) {
                    yield return character;
                }
            }
        }

        /// <summary>
        /// Enumerates the lower case hexadecimal characters.
        /// </summary>
        internal static IEnumerable<char> UppercaseHexadecimalCharacters {
            get {
                foreach (var character in LowercaseHexadecimalCharacters) {
                    yield return char.ToUpper(character);
                }
            }
        }

        /// <summary>
        /// Enumerates the lower case hexadecimal characters.
        /// </summary>
        internal static IEnumerable<char> AllHexadecimalCharacters {
            get {
                foreach (var character in LowercaseHexadecimalCharacters) {
                    if (char.IsLetter(character)) {
                        yield return char.ToUpper(character);
                    }
                    yield return character;
                }
            }
        }

        /// <summary>
        /// Enumerates the non-hexadecimal characters.
        /// </summary>
        /// <remarks>
        /// Normally this property enumerates the upper and lower case latin letters from g-z and
        /// the special characters from the EN-US keyboard.
        /// 
        /// When compiled with TEST_ALL_CHARACTERS this enumeration will iterate ~2^32 characters.
        /// It takes a LONG time.
        /// </remarks>
        internal static IEnumerable<char> NonHexadecimalCharacters {
            get {
#if TEST_ALL_CHARACTERS
                var hexadecimalCharacters = AllHexadecimalCharacters.ToArray();
                for (var c = char.MinValue; c < char.MaxValue; c += (char)1) {
                    if (Array.IndexOf(hexadecimalCharacters, c) == -1) {
                        yield return c;
                    }
                }
#else
                foreach (var character in
                    "ghijklmnopqrstuvwxyz~!@#$%^&*()_+{}:\"<>?`-=[];',./".ToCharArray()) {
                    if (char.IsLetter(character)) {
                        yield return char.ToUpper(character);
                    }
                    yield return character;
                }
#endif
            }
        }

    }
}
