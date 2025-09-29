#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public static class Convert
    {
        public static readonly object DBNull;

        public static TypeCode GetTypeCode(object value);
        public static bool IsDBNull(object value);
        public static object ChangeType(object value, TypeCode typeCode);
        public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider);
        public static object ChangeType(object value, Type conversionType);
        public static object ChangeType(object value, Type conversionType, IFormatProvider provider);
        public static bool ToBoolean(object value);
        public static bool ToBoolean(object value, IFormatProvider provider);
        public static bool ToBoolean(bool value);
        [CLSCompliant(False)]
        public static bool ToBoolean(sbyte value);
        public static bool ToBoolean(char value);
        public static bool ToBoolean(byte value);
        public static bool ToBoolean(short value);
        [CLSCompliant(False)]
        public static bool ToBoolean(ushort value);
        public static bool ToBoolean(int value);
        [CLSCompliant(False)]
        public static bool ToBoolean(uint value);
        public static bool ToBoolean(long value);
        [CLSCompliant(False)]
        public static bool ToBoolean(ulong value);
        public static bool ToBoolean(string value);
        public static bool ToBoolean(string value, IFormatProvider provider);
        public static bool ToBoolean(float value);
        public static bool ToBoolean(double value);
        public static bool ToBoolean(decimal value);
        public static bool ToBoolean(DateTime value);
        public static char ToChar(object value);
        public static char ToChar(object value, IFormatProvider provider);
        public static char ToChar(bool value);
        public static char ToChar(char value);
        [CLSCompliant(False)]
        public static char ToChar(sbyte value);
        public static char ToChar(byte value);
        public static char ToChar(short value);
        [CLSCompliant(False)]
        public static char ToChar(ushort value);
        public static char ToChar(int value);
        [CLSCompliant(False)]
        public static char ToChar(uint value);
        public static char ToChar(long value);
        [CLSCompliant(False)]
        public static char ToChar(ulong value);
        public static char ToChar(string value);
        public static char ToChar(string value, IFormatProvider provider);
        public static char ToChar(float value);
        public static char ToChar(double value);
        public static char ToChar(decimal value);
        public static char ToChar(DateTime value);
        [CLSCompliant(False)]
        public static sbyte ToSByte(object value);
        [CLSCompliant(False)]
        public static sbyte ToSByte(object value, IFormatProvider provider);
        [CLSCompliant(False)]
        public static sbyte ToSByte(bool value);
        [CLSCompliant(False)]
        public static sbyte ToSByte(sbyte value);
        [CLSCompliant(False)]
        public static sbyte ToSByte(char value);
        [CLSCompliant(False)]
        public static sbyte ToSByte(byte value);
        [CLSCompliant(False)]
        public static sbyte ToSByte(short value);
        [CLSCompliant(False)]
        public static sbyte ToSByte(ushort value);
        [CLSCompliant(False)]
        public static sbyte ToSByte(int value);
        [CLSCompliant(False)]
        public static sbyte ToSByte(uint value);
        [CLSCompliant(False)]
        public static sbyte ToSByte(long value);
        [CLSCompliant(False)]
        public static sbyte ToSByte(ulong value);
        [CLSCompliant(False)]
        public static sbyte ToSByte(float value);
        [CLSCompliant(False)]
        public static sbyte ToSByte(double value);
        [CLSCompliant(False)]
        public static sbyte ToSByte(decimal value);
        [CLSCompliant(False)]
        public static sbyte ToSByte(string value);
        [CLSCompliant(False)]
        public static sbyte ToSByte(string value, IFormatProvider provider);
        [CLSCompliant(False)]
        public static sbyte ToSByte(DateTime value);
        public static byte ToByte(object value);
        public static byte ToByte(object value, IFormatProvider provider);
        public static byte ToByte(bool value);
        public static byte ToByte(byte value);
        public static byte ToByte(char value);
        [CLSCompliant(False)]
        public static byte ToByte(sbyte value);
        public static byte ToByte(short value);
        [CLSCompliant(False)]
        public static byte ToByte(ushort value);
        public static byte ToByte(int value);
        [CLSCompliant(False)]
        public static byte ToByte(uint value);
        public static byte ToByte(long value);
        [CLSCompliant(False)]
        public static byte ToByte(ulong value);
        public static byte ToByte(float value);
        public static byte ToByte(double value);
        public static byte ToByte(decimal value);
        public static byte ToByte(string value);
        public static byte ToByte(string value, IFormatProvider provider);
        public static byte ToByte(DateTime value);
        public static short ToInt16(object value);
        public static short ToInt16(object value, IFormatProvider provider);
        public static short ToInt16(bool value);
        public static short ToInt16(char value);
        [CLSCompliant(False)]
        public static short ToInt16(sbyte value);
        public static short ToInt16(byte value);
        [CLSCompliant(False)]
        public static short ToInt16(ushort value);
        public static short ToInt16(int value);
        [CLSCompliant(False)]
        public static short ToInt16(uint value);
        public static short ToInt16(short value);
        public static short ToInt16(long value);
        [CLSCompliant(False)]
        public static short ToInt16(ulong value);
        public static short ToInt16(float value);
        public static short ToInt16(double value);
        public static short ToInt16(decimal value);
        public static short ToInt16(string value);
        public static short ToInt16(string value, IFormatProvider provider);
        public static short ToInt16(DateTime value);
        [CLSCompliant(False)]
        public static ushort ToUInt16(object value);
        [CLSCompliant(False)]
        public static ushort ToUInt16(object value, IFormatProvider provider);
        [CLSCompliant(False)]
        public static ushort ToUInt16(bool value);
        [CLSCompliant(False)]
        public static ushort ToUInt16(char value);
        [CLSCompliant(False)]
        public static ushort ToUInt16(sbyte value);
        [CLSCompliant(False)]
        public static ushort ToUInt16(byte value);
        [CLSCompliant(False)]
        public static ushort ToUInt16(short value);
        [CLSCompliant(False)]
        public static ushort ToUInt16(int value);
        [CLSCompliant(False)]
        public static ushort ToUInt16(ushort value);
        [CLSCompliant(False)]
        public static ushort ToUInt16(uint value);
        [CLSCompliant(False)]
        public static ushort ToUInt16(long value);
        [CLSCompliant(False)]
        public static ushort ToUInt16(ulong value);
        [CLSCompliant(False)]
        public static ushort ToUInt16(float value);
        [CLSCompliant(False)]
        public static ushort ToUInt16(double value);
        [CLSCompliant(False)]
        public static ushort ToUInt16(decimal value);
        [CLSCompliant(False)]
        public static ushort ToUInt16(string value);
        [CLSCompliant(False)]
        public static ushort ToUInt16(string value, IFormatProvider provider);
        [CLSCompliant(False)]
        public static ushort ToUInt16(DateTime value);
        public static int ToInt32(object value);
        public static int ToInt32(object value, IFormatProvider provider);
        public static int ToInt32(bool value);
        public static int ToInt32(char value);
        [CLSCompliant(False)]
        public static int ToInt32(sbyte value);
        public static int ToInt32(byte value);
        public static int ToInt32(short value);
        [CLSCompliant(False)]
        public static int ToInt32(ushort value);
        [CLSCompliant(False)]
        public static int ToInt32(uint value);
        public static int ToInt32(int value);
        public static int ToInt32(long value);
        [CLSCompliant(False)]
        public static int ToInt32(ulong value);
        public static int ToInt32(float value);
        public static int ToInt32(double value);
        public static int ToInt32(decimal value);
        public static int ToInt32(string value);
        public static int ToInt32(string value, IFormatProvider provider);
        public static int ToInt32(DateTime value);
        [CLSCompliant(False)]
        public static uint ToUInt32(object value);
        [CLSCompliant(False)]
        public static uint ToUInt32(object value, IFormatProvider provider);
        [CLSCompliant(False)]
        public static uint ToUInt32(bool value);
        [CLSCompliant(False)]
        public static uint ToUInt32(char value);
        [CLSCompliant(False)]
        public static uint ToUInt32(sbyte value);
        [CLSCompliant(False)]
        public static uint ToUInt32(byte value);
        [CLSCompliant(False)]
        public static uint ToUInt32(short value);
        [CLSCompliant(False)]
        public static uint ToUInt32(ushort value);
        [CLSCompliant(False)]
        public static uint ToUInt32(int value);
        [CLSCompliant(False)]
        public static uint ToUInt32(uint value);
        [CLSCompliant(False)]
        public static uint ToUInt32(long value);
        [CLSCompliant(False)]
        public static uint ToUInt32(ulong value);
        [CLSCompliant(False)]
        public static uint ToUInt32(float value);
        [CLSCompliant(False)]
        public static uint ToUInt32(double value);
        [CLSCompliant(False)]
        public static uint ToUInt32(decimal value);
        [CLSCompliant(False)]
        public static uint ToUInt32(string value);
        [CLSCompliant(False)]
        public static uint ToUInt32(string value, IFormatProvider provider);
        [CLSCompliant(False)]
        public static uint ToUInt32(DateTime value);
        public static long ToInt64(object value);
        public static long ToInt64(object value, IFormatProvider provider);
        public static long ToInt64(bool value);
        public static long ToInt64(char value);
        [CLSCompliant(False)]
        public static long ToInt64(sbyte value);
        public static long ToInt64(byte value);
        public static long ToInt64(short value);
        [CLSCompliant(False)]
        public static long ToInt64(ushort value);
        public static long ToInt64(int value);
        [CLSCompliant(False)]
        public static long ToInt64(uint value);
        [CLSCompliant(False)]
        public static long ToInt64(ulong value);
        public static long ToInt64(long value);
        public static long ToInt64(float value);
        public static long ToInt64(double value);
        public static long ToInt64(decimal value);
        public static long ToInt64(string value);
        public static long ToInt64(string value, IFormatProvider provider);
        public static long ToInt64(DateTime value);
        [CLSCompliant(False)]
        public static ulong ToUInt64(object value);
        [CLSCompliant(False)]
        public static ulong ToUInt64(object value, IFormatProvider provider);
        [CLSCompliant(False)]
        public static ulong ToUInt64(bool value);
        [CLSCompliant(False)]
        public static ulong ToUInt64(char value);
        [CLSCompliant(False)]
        public static ulong ToUInt64(sbyte value);
        [CLSCompliant(False)]
        public static ulong ToUInt64(byte value);
        [CLSCompliant(False)]
        public static ulong ToUInt64(short value);
        [CLSCompliant(False)]
        public static ulong ToUInt64(ushort value);
        [CLSCompliant(False)]
        public static ulong ToUInt64(int value);
        [CLSCompliant(False)]
        public static ulong ToUInt64(uint value);
        [CLSCompliant(False)]
        public static ulong ToUInt64(long value);
        [CLSCompliant(False)]
        public static ulong ToUInt64(ulong value);
        [CLSCompliant(False)]
        public static ulong ToUInt64(float value);
        [CLSCompliant(False)]
        public static ulong ToUInt64(double value);
        [CLSCompliant(False)]
        public static ulong ToUInt64(decimal value);
        [CLSCompliant(False)]
        public static ulong ToUInt64(string value);
        [CLSCompliant(False)]
        public static ulong ToUInt64(string value, IFormatProvider provider);
        [CLSCompliant(False)]
        public static ulong ToUInt64(DateTime value);
        public static float ToSingle(object value);
        public static float ToSingle(object value, IFormatProvider provider);
        [CLSCompliant(False)]
        public static float ToSingle(sbyte value);
        public static float ToSingle(byte value);
        public static float ToSingle(char value);
        public static float ToSingle(short value);
        [CLSCompliant(False)]
        public static float ToSingle(ushort value);
        public static float ToSingle(int value);
        [CLSCompliant(False)]
        public static float ToSingle(uint value);
        public static float ToSingle(long value);
        [CLSCompliant(False)]
        public static float ToSingle(ulong value);
        public static float ToSingle(float value);
        public static float ToSingle(double value);
        public static float ToSingle(decimal value);
        public static float ToSingle(string value);
        public static float ToSingle(string value, IFormatProvider provider);
        public static float ToSingle(bool value);
        public static float ToSingle(DateTime value);
        public static double ToDouble(object value);
        public static double ToDouble(object value, IFormatProvider provider);
        [CLSCompliant(False)]
        public static double ToDouble(sbyte value);
        public static double ToDouble(byte value);
        public static double ToDouble(short value);
        public static double ToDouble(char value);
        [CLSCompliant(False)]
        public static double ToDouble(ushort value);
        public static double ToDouble(int value);
        [CLSCompliant(False)]
        public static double ToDouble(uint value);
        public static double ToDouble(long value);
        [CLSCompliant(False)]
        public static double ToDouble(ulong value);
        public static double ToDouble(float value);
        public static double ToDouble(double value);
        public static double ToDouble(decimal value);
        public static double ToDouble(string value);
        public static double ToDouble(string value, IFormatProvider provider);
        public static double ToDouble(bool value);
        public static double ToDouble(DateTime value);
        public static decimal ToDecimal(object value);
        public static decimal ToDecimal(object value, IFormatProvider provider);
        [CLSCompliant(False)]
        public static decimal ToDecimal(sbyte value);
        public static decimal ToDecimal(byte value);
        public static decimal ToDecimal(char value);
        public static decimal ToDecimal(short value);
        [CLSCompliant(False)]
        public static decimal ToDecimal(ushort value);
        public static decimal ToDecimal(int value);
        [CLSCompliant(False)]
        public static decimal ToDecimal(uint value);
        public static decimal ToDecimal(long value);
        [CLSCompliant(False)]
        public static decimal ToDecimal(ulong value);
        public static decimal ToDecimal(float value);
        public static decimal ToDecimal(double value);
        public static decimal ToDecimal(string value);
        public static decimal ToDecimal(string value, IFormatProvider provider);
        public static decimal ToDecimal(decimal value);
        public static decimal ToDecimal(bool value);
        public static decimal ToDecimal(DateTime value);
        public static DateTime ToDateTime(DateTime value);
        public static DateTime ToDateTime(object value);
        public static DateTime ToDateTime(object value, IFormatProvider provider);
        public static DateTime ToDateTime(string value);
        public static DateTime ToDateTime(string value, IFormatProvider provider);
        [CLSCompliant(False)]
        public static DateTime ToDateTime(sbyte value);
        public static DateTime ToDateTime(byte value);
        public static DateTime ToDateTime(short value);
        [CLSCompliant(False)]
        public static DateTime ToDateTime(ushort value);
        public static DateTime ToDateTime(int value);
        [CLSCompliant(False)]
        public static DateTime ToDateTime(uint value);
        public static DateTime ToDateTime(long value);
        [CLSCompliant(False)]
        public static DateTime ToDateTime(ulong value);
        public static DateTime ToDateTime(bool value);
        public static DateTime ToDateTime(char value);
        public static DateTime ToDateTime(float value);
        public static DateTime ToDateTime(double value);
        public static DateTime ToDateTime(decimal value);
        public static string ToString(object value);
        public static string ToString(object value, IFormatProvider provider);
        public static string ToString(bool value);
        public static string ToString(bool value, IFormatProvider provider);
        public static string ToString(char value);
        public static string ToString(char value, IFormatProvider provider);
        [CLSCompliant(False)]
        public static string ToString(sbyte value);
        [CLSCompliant(False)]
        public static string ToString(sbyte value, IFormatProvider provider);
        public static string ToString(byte value);
        public static string ToString(byte value, IFormatProvider provider);
        public static string ToString(short value);
        public static string ToString(short value, IFormatProvider provider);
        [CLSCompliant(False)]
        public static string ToString(ushort value);
        [CLSCompliant(False)]
        public static string ToString(ushort value, IFormatProvider provider);
        public static string ToString(int value);
        public static string ToString(int value, IFormatProvider provider);
        [CLSCompliant(False)]
        public static string ToString(uint value);
        [CLSCompliant(False)]
        public static string ToString(uint value, IFormatProvider provider);
        public static string ToString(long value);
        public static string ToString(long value, IFormatProvider provider);
        [CLSCompliant(False)]
        public static string ToString(ulong value);
        [CLSCompliant(False)]
        public static string ToString(ulong value, IFormatProvider provider);
        public static string ToString(float value);
        public static string ToString(float value, IFormatProvider provider);
        public static string ToString(double value);
        public static string ToString(double value, IFormatProvider provider);
        public static string ToString(decimal value);
        public static string ToString(decimal value, IFormatProvider provider);
        public static string ToString(DateTime value);
        public static string ToString(DateTime value, IFormatProvider provider);
        public static string ToString(string value);
        public static string ToString(string value, IFormatProvider provider);
        public static byte ToByte(string value, int fromBase);
        [CLSCompliant(False)]
        public static sbyte ToSByte(string value, int fromBase);
        public static short ToInt16(string value, int fromBase);
        [CLSCompliant(False)]
        public static ushort ToUInt16(string value, int fromBase);
        public static int ToInt32(string value, int fromBase);
        [CLSCompliant(False)]
        public static uint ToUInt32(string value, int fromBase);
        public static long ToInt64(string value, int fromBase);
        [CLSCompliant(False)]
        public static ulong ToUInt64(string value, int fromBase);
        public static string ToString(byte value, int toBase);
        public static string ToString(short value, int toBase);
        public static string ToString(int value, int toBase);
        public static string ToString(long value, int toBase);
        public static string ToBase64String(byte[] inArray);
        public static string ToBase64String(byte[] inArray, Base64FormattingOptions options);
        public static string ToBase64String(byte[] inArray, int offset, int length);
        public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options);
        public static string ToBase64String(ReadOnlySpan<byte> bytes, Base64FormattingOptions options = Base64FormattingOptions.None);
        public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut);
        public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options);
        public static bool TryToBase64Chars(ReadOnlySpan<byte> bytes, Span<char> chars, out int charsWritten, Base64FormattingOptions options = Base64FormattingOptions.None);
        public static byte[] FromBase64String(string s);
        public static bool TryFromBase64String(string s, Span<byte> bytes, out int bytesWritten);
        public static bool TryFromBase64Chars(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten);
        public static byte[] FromBase64CharArray(char[] inArray, int offset, int length);
        public static byte[] FromHexString(string s);
        public static byte[] FromHexString(ReadOnlySpan<char> chars);
        public static string ToHexString(byte[] inArray);
        public static string ToHexString(byte[] inArray, int offset, int length);
        public static string ToHexString(ReadOnlySpan<byte> bytes);
    }
}
