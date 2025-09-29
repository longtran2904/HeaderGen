#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.Runtime.CompilerServices;

namespace System
{
    public class Tuple<T1, T2, T3, T4, T5, T6, T7> : IComparable, IStructuralComparable, IStructuralEquatable, ITuple, ITupleInternal
    {

        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7);

        public T1 Item1 { get; }
        public T2 Item2 { get; }
        public T3 Item3 { get; }
        public T4 Item4 { get; }
        public T5 Item5 { get; }
        public T6 Item6 { get; }
        public T7 Item7 { get; }

        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();
    }
}
