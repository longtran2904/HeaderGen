#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.Runtime.CompilerServices;

namespace System
{
    public struct ValueTuple<T1, T2> : IComparable, IComparable<(T1, T2)>, IEquatable<(T1, T2)>, IStructuralComparable, IStructuralEquatable, ITuple, IValueTupleInternal
    {

        public T1 Item1;
        public T2 Item2;

        public ValueTuple(T1 item1, T2 item2);

        public override bool Equals(object obj);
        public bool Equals((T1, T2) other);
        public int CompareTo((T1, T2) other);
        public override int GetHashCode();
        public override string ToString();
    }
}
