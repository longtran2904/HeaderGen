#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Collections.Generic
{
    public sealed class GenericEqualityComparer<T> : EqualityComparer<T> where T : IEquatable<T>
    {

        public GenericEqualityComparer();

        public override bool Equals(T x, T y);
        public override int GetHashCode(T obj);
        public override bool Equals(object obj);
        public override int GetHashCode();
    }
}
