using System;

namespace hexString {

    /// <summary>
    /// A <see cref="HexString"/> is a convenience type for representing a <see cref="byte"/>
    /// array as a <see cref="string"/>.
    /// </summary>
    public sealed partial class HexString {

        private string _hexadecimalString;
        private byte[] _bytes;

        /// <summary>
        /// Initializes a new <see cref="HexString"/> from a hexadecimal <see cref="string"/>.  
        /// </summary>
        /// <param name="hexadecimalString">The string.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="hexadecimalString"/> is <c>null</c>.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="hexadecimalString"/> is not a valid HexString.
        /// </exception>
        public HexString(string hexadecimalString) {
            if (hexadecimalString == null) {
                throw new ArgumentNullException("hexadecimalString");
            }
            _bytes = GetBytes(hexadecimalString);
            _hexadecimalString = hexadecimalString;
        }

        /// <summary>
        /// Initializes a new <see cref="HexString"/> from a <see cref="byte"/>[]. 
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="bytes"/> is <c>null</c>.
        /// </exception>
        public HexString(byte[] bytes) {
            if (bytes == null) { throw new ArgumentNullException("bytes"); }
            _hexadecimalString = GetString(bytes);
            _bytes = bytes;
        }

        /// <summary>
        /// Gets the hexadecimal string representation.
        /// </summary>
        /// <returns>The hexadecimal string.</returns>
        public override string ToString() {
            return _hexadecimalString;
        }
    }
}
