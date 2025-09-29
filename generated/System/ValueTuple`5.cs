#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.Runtime.CompilerServices;

namespace System
{
    public struct ValueTuple<T1, T2, T3, T4, T5> : IComparable, IComparable<(T1, T2, T3, T4, T5)>, IEquatable<(T1, T2, T3, T4, T5)>, IStructuralComparable, IStructuralEquatable, ITuple, IValueTupleInternal
    {
        public T1 Item1;
        public T2 Item2;
        public T3 Item3;
        public T4 Item4;
        public T5 Item5;

        public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5);

        public override bool Equals(object obj);
        public bool Equals((T1, T2, T3, T4, T5) other);
        public int CompareTo((T1, T2, T3, T4, T5) other);
        public override int GetHashCode();
        public override string ToString();
    }
}
