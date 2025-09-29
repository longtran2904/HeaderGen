#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System
{
    public struct RuntimeMethodHandle : IEquatable<RuntimeMethodHandle>, ISerializable
    {
        public nint Value { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public void GetObjectData(SerializationInfo info, StreamingContext context);
        public override int GetHashCode();
        public override bool Equals(object obj);
        public static RuntimeMethodHandle FromIntPtr(nint value);
        public static nint ToIntPtr(RuntimeMethodHandle value);
        public bool Equals(RuntimeMethodHandle handle);
        public nint GetFunctionPointer();

        public static bool operator ==(RuntimeMethodHandle left, RuntimeMethodHandle right);
        public static bool operator !=(RuntimeMethodHandle left, RuntimeMethodHandle right);
    }
}
