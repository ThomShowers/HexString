using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
