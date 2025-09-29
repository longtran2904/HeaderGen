#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;
using System.ComponentModel;

namespace System
{
    public struct HashCode
    {

        public static int Combine<T1>(T1 value1);
        public static int Combine<T1, T2>(T1 value1, T2 value2);
        public static int Combine<T1, T2, T3>(T1 value1, T2 value2, T3 value3);
        public static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4);
        public static int Combine<T1, T2, T3, T4, T5>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5);
        public static int Combine<T1, T2, T3, T4, T5, T6>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6);
        public static int Combine<T1, T2, T3, T4, T5, T6, T7>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7);
        public static int Combine<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8);
        public void Add<T>(T value);
        public void Add<T>(T value, IEqualityComparer<T> comparer);
        public void AddBytes(ReadOnlySpan<byte> value);
        public int ToHashCode();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes. Use ToHashCode to retrieve the computed hash code.", True)]
        public override int GetHashCode();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes.", True)]
        public override bool Equals(object obj);
    }
}
