#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Collections.Generic
{
    public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T>
    {

        protected EqualityComparer();

        public static EqualityComparer<T> Default { get; }

        public static EqualityComparer<T> Create(Func<T, T, bool> equals, Func<T, int> getHashCode = null);
        public abstract bool Equals(T x, T y);
        public abstract int GetHashCode(T obj);
    }
}
