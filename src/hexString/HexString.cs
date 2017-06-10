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
            _hexadecimalString = hexadecimalString.ToLower();
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
            _bytes = bytes.Clone() as byte[];
        }

        /// <summary>
        /// Gets the bytes represented by the <see cref="HexString"/>. 
        /// </summary>
        /// <returns>A <see cref="byte"/>[].</returns>
        public byte[] ToBytes() {
            return _bytes.Clone() as byte[];
        }

        /// <summary>
        /// Gets the hexadecimal string representation.
        /// </summary>
        /// <returns>The hexadecimal string.</returns>
        public override string ToString() {
            return _hexadecimalString;
        }

        public override bool Equals(object obj) {
            var otherHexString = obj as HexString;
            return this == otherHexString;
        }

        public override int GetHashCode() {
            return _hexadecimalString.GetHashCode();
        }

        /// <summary>
        /// Implements the == operator as a value equality comparison.
        /// </summary>
        /// <param name="left">The left <see cref="HexString"/>.</param>
        /// <param name="right">The right <see cref="HexString"/>.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal values,
        /// otherwise <c>false</c>.
        /// </returns>
        public static bool operator ==(HexString left, HexString right) {
            if (left == (object)right) { return true; }
            if (((object)left) == null || ((object)right) == null) { return false; }
            return left.ToString() == right.ToString();
        }

        /// <summary>
        /// Implements the != operator as a value inequality comparison.
        /// </summary>
        /// <param name="left">The left <see cref="HexString"/>.</param>
        /// <param name="right">The right <see cref="HexString"/>.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="left"/> and <paramref name="right"/> are inequal values,
        /// otherwise <c>false</c>.
        /// </returns>
        public static bool operator !=(HexString left, HexString right) {
            return !(left == right);
        }

        /// <summary>
        /// Casts a <see cref="HexString"/> as a <see cref="string"/>.  
        /// </summary>
        /// <param name="hexString">The <see cref="HexString"/>.</param>
        public static implicit operator string(HexString hexString) {
            return hexString.ToString();
        }

        /// <summary>
        /// Casts a <see cref="HexString"/> as a <see cref="byte"/>[].  
        /// </summary>
        /// <param name="hexString">The <see cref="HexString"/>.</param>
        public static implicit operator byte[] (HexString hexString) {
            return hexString.ToBytes();
        }

        /// <summary>
        /// Casts a <see cref="byte"/>[] as a <see cref="HexString"/>.
        /// </summary>
        /// <param name="bytes">The <see cref="byte"/>[].</param>
        public static implicit operator HexString(byte[] bytes) {
            return new HexString(bytes);
        }
    }
}
