#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Collections.Generic
{
    public abstract class Comparer<T> : IComparer, IComparer<T>
    {

        protected Comparer();

        public static Comparer<T> Default { get; }

        public static Comparer<T> Create(Comparison<T> comparison);
        public abstract int Compare(T x, T y);
    }
}
