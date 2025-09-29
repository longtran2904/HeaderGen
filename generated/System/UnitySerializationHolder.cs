#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Serialization;

namespace System
{
    [Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
    public sealed class UnitySerializationHolder : IObjectReference, ISerializable
    {
        public UnitySerializationHolder(SerializationInfo info, StreamingContext context);

        public void GetObjectData(SerializationInfo info, StreamingContext context);
        public object GetRealObject(StreamingContext context);
    }
}
