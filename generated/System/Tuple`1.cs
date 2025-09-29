#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.Runtime.CompilerServices;

namespace System
{
    public class Tuple<T1> : IComparable, IStructuralComparable, IStructuralEquatable, ITuple, ITupleInternal
    {

        public Tuple(T1 item1);

        public T1 Item1 { get; }

        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();
    }
}
