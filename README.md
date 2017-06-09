# HexString
A convenience type for representing bytes as a string in hexadecimal notation.

## What is a HexString?

A HexString is a type that can represent a series of bytes as either a byte array or a string in
hexadecimal notation. Since we're representing bytes rather than a numeric value the strings always
have an even number of characters and the values 0-15 are represented with leading zeros.

For example, the bytes { 0, 1, 2, 3 } would be represented in hexadecimal as "00010203", and the
hexadecimal string "FACE" would represent the bytes { 250, 206 }.

Instances of HexString have methods for getting each representation, and the type has static
methods for validating strings and converting between representations.

The type also supports casting from HexString to byte[], from HexString to string, and from byte[]
to HexString.