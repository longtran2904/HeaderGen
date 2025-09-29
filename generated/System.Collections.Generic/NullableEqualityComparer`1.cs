#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Serialization;

namespace System.Collections.Generic
{
    public sealed class NullableEqualityComparer<T> : EqualityComparer<T?>, ISerializable where T : struct
    {
        public NullableEqualityComparer();

        public void GetObjectData(SerializationInfo info, StreamingContext context);
        public override bool Equals(T? x, T? y);
        public override int GetHashCode(T? obj);
        public override bool Equals(object obj);
        public override int GetHashCode();
    }
}
