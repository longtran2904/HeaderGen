#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;

namespace System.Text
{
    [DefaultMember("Chars")]
    public sealed class StringBuilder : ISerializable
    {

        public StringBuilder();
        public StringBuilder(int capacity);
        public StringBuilder(string value);
        public StringBuilder(string value, int capacity);
        public StringBuilder(string value, int startIndex, int length, int capacity);
        public StringBuilder(int capacity, int maxCapacity);

        public char this[int index] { get; set; }
        public int Capacity { get; set; }
        public int MaxCapacity { get; }
        public int Length { get; set; }

        public int EnsureCapacity(int capacity);
        public override string ToString();
        public string ToString(int startIndex, int length);
        public StringBuilder Clear();
        public ChunkEnumerator GetChunks();
        public StringBuilder Append(char value, int repeatCount);
        public StringBuilder Append(char[] value, int startIndex, int charCount);
        public StringBuilder Append(string value);
        public StringBuilder Append(string value, int startIndex, int count);
        public StringBuilder Append(StringBuilder value);
        public StringBuilder Append(StringBuilder value, int startIndex, int count);
        public StringBuilder AppendLine();
        public StringBuilder AppendLine(string value);
        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count);
        public void CopyTo(int sourceIndex, Span<char> destination, int count);
        public StringBuilder Insert(int index, string value, int count);
        public StringBuilder Remove(int startIndex, int length);
        public StringBuilder Append(bool value);
        public StringBuilder Append(char value);
        [CLSCompliant(False)]
        public StringBuilder Append(sbyte value);
        public StringBuilder Append(byte value);
        public StringBuilder Append(short value);
        public StringBuilder Append(int value);
        public StringBuilder Append(long value);
        public StringBuilder Append(float value);
        public StringBuilder Append(double value);
        public StringBuilder Append(decimal value);
        [CLSCompliant(False)]
        public StringBuilder Append(ushort value);
        [CLSCompliant(False)]
        public StringBuilder Append(uint value);
        [CLSCompliant(False)]
        public StringBuilder Append(ulong value);
        public StringBuilder Append(object value);
        public StringBuilder Append(char[] value);
        public StringBuilder Append(ReadOnlySpan<char> value);
        public StringBuilder Append(ReadOnlyMemory<char> value);
        public StringBuilder Append(ref AppendInterpolatedStringHandler handler);
        public StringBuilder Append(IFormatProvider provider, ref AppendInterpolatedStringHandler handler);
        public StringBuilder AppendLine(ref AppendInterpolatedStringHandler handler);
        public StringBuilder AppendLine(IFormatProvider provider, ref AppendInterpolatedStringHandler handler);
        public StringBuilder AppendJoin(string separator, params object[] values);
        public StringBuilder AppendJoin<T>(string separator, IEnumerable<T> values);
        public StringBuilder AppendJoin(string separator, params string[] values);
        public StringBuilder AppendJoin(char separator, params object[] values);
        public StringBuilder AppendJoin<T>(char separator, IEnumerable<T> values);
        public StringBuilder AppendJoin(char separator, params string[] values);
        public StringBuilder Insert(int index, string value);
        public StringBuilder Insert(int index, bool value);
        [CLSCompliant(False)]
        public StringBuilder Insert(int index, sbyte value);
        public StringBuilder Insert(int index, byte value);
        public StringBuilder Insert(int index, short value);
        public StringBuilder Insert(int index, char value);
        public StringBuilder Insert(int index, char[] value);
        public StringBuilder Insert(int index, char[] value, int startIndex, int charCount);
        public StringBuilder Insert(int index, int value);
        public StringBuilder Insert(int index, long value);
        public StringBuilder Insert(int index, float value);
        public StringBuilder Insert(int index, double value);
        public StringBuilder Insert(int index, decimal value);
        [CLSCompliant(False)]
        public StringBuilder Insert(int index, ushort value);
        [CLSCompliant(False)]
        public StringBuilder Insert(int index, uint value);
        [CLSCompliant(False)]
        public StringBuilder Insert(int index, ulong value);
        public StringBuilder Insert(int index, object value);
        public StringBuilder Insert(int index, ReadOnlySpan<char> value);
        public StringBuilder AppendFormat(string format, object arg0);
        public StringBuilder AppendFormat(string format, object arg0, object arg1);
        public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2);
        public StringBuilder AppendFormat(string format, params object[] args);
        public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0);
        public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1);
        public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1, object arg2);
        public StringBuilder AppendFormat(IFormatProvider provider, string format, params object[] args);
        public StringBuilder AppendFormat<TArg0>(IFormatProvider provider, CompositeFormat format, TArg0 arg0);
        public StringBuilder AppendFormat<TArg0, TArg1>(IFormatProvider provider, CompositeFormat format, TArg0 arg0, TArg1 arg1);
        public StringBuilder AppendFormat<TArg0, TArg1, TArg2>(IFormatProvider provider, CompositeFormat format, TArg0 arg0, TArg1 arg1, TArg2 arg2);
        public StringBuilder AppendFormat(IFormatProvider provider, CompositeFormat format, params object[] args);
        public StringBuilder AppendFormat(IFormatProvider provider, CompositeFormat format, ReadOnlySpan<object> args);
        public StringBuilder Replace(string oldValue, string newValue);
        public bool Equals(StringBuilder sb);
        public bool Equals(ReadOnlySpan<char> span);
        public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count);
        public StringBuilder Replace(char oldChar, char newChar);
        public StringBuilder Replace(char oldChar, char newChar, int startIndex, int count);
        [CLSCompliant(False)]
        public StringBuilder Append(char* value, int valueCount);
        public struct ChunkEnumerator
        {

            public ReadOnlyMemory<char> Current { get; }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ChunkEnumerator GetEnumerator();
            public bool MoveNext();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public struct AppendInterpolatedStringHandler
        {

            public AppendInterpolatedStringHandler(int literalLength, int formattedCount, StringBuilder stringBuilder);
            public AppendInterpolatedStringHandler(int literalLength, int formattedCount, StringBuilder stringBuilder, IFormatProvider provider);

            public void AppendLiteral(string value);
            public void AppendFormatted<T>(T value);
            public void AppendFormatted<T>(T value, string format);
            public void AppendFormatted<T>(T value, int alignment);
            public void AppendFormatted<T>(T value, int alignment, string format);
            public void AppendFormatted(ReadOnlySpan<char> value);
            public void AppendFormatted(ReadOnlySpan<char> value, int alignment = 0, string format = null);
            public void AppendFormatted(string value);
            public void AppendFormatted(string value, int alignment = 0, string format = null);
            public void AppendFormatted(object value, int alignment = 0, string format = null);
        }
    }
}
