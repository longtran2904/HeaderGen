#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public abstract class Enum : ValueType, IComparable, IConvertible, IFormattable, ISpanFormattable
    {
        protected Enum();

        public static string GetName<TEnum>(TEnum value) where TEnum : Enum, struct;
        public static string GetName(Type enumType, object value);
        public static string[] GetNames<TEnum>() where TEnum : Enum, struct;
        public static string[] GetNames(Type enumType);
        public static Type GetUnderlyingType(Type enumType);
        public static TEnum[] GetValues<TEnum>() where TEnum : Enum, struct;
        public static Array GetValues(Type enumType);
        public static Array GetValuesAsUnderlyingType<TEnum>() where TEnum : Enum, struct;
        public static Array GetValuesAsUnderlyingType(Type enumType);
        public bool HasFlag(Enum flag);
        public static bool IsDefined<TEnum>(TEnum value) where TEnum : Enum, struct;
        public static bool IsDefined(Type enumType, object value);
        public static object Parse(Type enumType, string value);
        public static object Parse(Type enumType, ReadOnlySpan<char> value);
        public static object Parse(Type enumType, string value, bool ignoreCase);
        public static object Parse(Type enumType, ReadOnlySpan<char> value, bool ignoreCase);
        public static TEnum Parse<TEnum>(string value) where TEnum : struct;
        public static TEnum Parse<TEnum>(ReadOnlySpan<char> value) where TEnum : struct;
        public static TEnum Parse<TEnum>(string value, bool ignoreCase) where TEnum : struct;
        public static TEnum Parse<TEnum>(ReadOnlySpan<char> value, bool ignoreCase) where TEnum : struct;
        public static bool TryParse(Type enumType, string value, out object result);
        public static bool TryParse(Type enumType, ReadOnlySpan<char> value, out object result);
        public static bool TryParse(Type enumType, string value, bool ignoreCase, out object result);
        public static bool TryParse(Type enumType, ReadOnlySpan<char> value, bool ignoreCase, out object result);
        public static bool TryParse<TEnum>(string value, out TEnum result) where TEnum : struct;
        public static bool TryParse<TEnum>(ReadOnlySpan<char> value, out TEnum result) where TEnum : struct;
        public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum : struct;
        public static bool TryParse<TEnum>(ReadOnlySpan<char> value, bool ignoreCase, out TEnum result) where TEnum : struct;
        public override bool Equals(object obj);
        public override int GetHashCode();
        public int CompareTo(object target);
        public override string ToString();
        public string ToString(string format);
        [Obsolete("The provider argument is not used. Use ToString() instead.")]
        public string ToString(IFormatProvider provider);
        [Obsolete("The provider argument is not used. Use ToString(String) instead.")]
        public string ToString(string format, IFormatProvider provider);
        public static string Format(Type enumType, object value, string format);
        public static bool TryFormat<TEnum>(TEnum value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null) where TEnum : Enum, struct;
        public TypeCode GetTypeCode();
        public static object ToObject(Type enumType, object value);
        [CLSCompliant(False)]
        public static object ToObject(Type enumType, sbyte value);
        public static object ToObject(Type enumType, short value);
        public static object ToObject(Type enumType, int value);
        public static object ToObject(Type enumType, byte value);
        [CLSCompliant(False)]
        public static object ToObject(Type enumType, ushort value);
        [CLSCompliant(False)]
        public static object ToObject(Type enumType, uint value);
        public static object ToObject(Type enumType, long value);
        [CLSCompliant(False)]
        public static object ToObject(Type enumType, ulong value);
    }
}
