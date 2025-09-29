#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.Runtime.CompilerServices;

namespace System
{
    public struct ValueTuple<T1> : IComparable, IComparable<(T1)>, IEquatable<(T1)>, IStructuralComparable, IStructuralEquatable, ITuple, IValueTupleInternal
    {
        public T1 Item1;

        public ValueTuple(T1 item1);

        public override bool Equals(object obj);
        public bool Equals((T1) other);
        public int CompareTo((T1) other);
        public override int GetHashCode();
        public override string ToString();
    }
}
