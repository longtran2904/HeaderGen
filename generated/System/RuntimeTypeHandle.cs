#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System
{
    public struct RuntimeTypeHandle : IEquatable<RuntimeTypeHandle>, ISerializable
    {

        public nint Value { get; }

        public static RuntimeTypeHandle FromIntPtr(nint value);
        public static nint ToIntPtr(RuntimeTypeHandle value);
        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(RuntimeTypeHandle handle);
        public ModuleHandle GetModuleHandle();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public void GetObjectData(SerializationInfo info, StreamingContext context);

        public static bool operator ==(RuntimeTypeHandle left, object right);
        public static bool operator ==(object left, RuntimeTypeHandle right);
        public static bool operator !=(RuntimeTypeHandle left, object right);
        public static bool operator !=(object left, RuntimeTypeHandle right);
    }
}
