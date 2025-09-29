#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Numerics
{
    public readonly struct TotalOrderIeee754Comparer<T> : IComparer<T>, IEqualityComparer<T>, IEquatable<TotalOrderIeee754Comparer<T>> where T : IFloatingPointIeee754<T>
    {
        public int Compare(T x, T y);
        public bool Equals(T x, T y);
        public int GetHashCode(T obj);
        public bool Equals(TotalOrderIeee754Comparer<T> other);
        public override bool Equals(object obj);
        public override int GetHashCode();
    }
}
