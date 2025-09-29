#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;

namespace System.Reflection
{
    [Obsolete("Strong name signing is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0017", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
    public class StrongNameKeyPair : IDeserializationCallback, ISerializable
    {
        public StrongNameKeyPair(FileStream keyPairFile);
        public StrongNameKeyPair(byte[] keyPairArray);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected StrongNameKeyPair(SerializationInfo info, StreamingContext context);
        public StrongNameKeyPair(string keyPairContainer);

        public byte[] PublicKey { get; }
    }
}
