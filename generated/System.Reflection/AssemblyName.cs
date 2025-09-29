#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Reflection
{
    public sealed class AssemblyName : ICloneable, IDeserializationCallback, ISerializable
    {

        public AssemblyName(string assemblyName);
        public AssemblyName();

        public string Name { get; set; }
        public Version Version { get; set; }
        public CultureInfo CultureInfo { get; set; }
        public string CultureName { get; set; }
        [Obsolete("AssemblyName.CodeBase and AssemblyName.EscapedCodeBase are obsolete. Using them for loading an assembly is not supported.", DiagnosticId = "SYSLIB0044", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public string CodeBase { get; set; }
        [Obsolete("AssemblyName.CodeBase and AssemblyName.EscapedCodeBase are obsolete. Using them for loading an assembly is not supported.", DiagnosticId = "SYSLIB0044", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public string EscapedCodeBase { get; }
        [Obsolete("AssemblyName members HashAlgorithm, ProcessorArchitecture, and VersionCompatibility are obsolete and not supported.", DiagnosticId = "SYSLIB0037", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public ProcessorArchitecture ProcessorArchitecture { get; set; }
        public AssemblyContentType ContentType { get; set; }
        public AssemblyNameFlags Flags { get; set; }
        [Obsolete("AssemblyName members HashAlgorithm, ProcessorArchitecture, and VersionCompatibility are obsolete and not supported.", DiagnosticId = "SYSLIB0037", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public AssemblyHashAlgorithm HashAlgorithm { get; set; }
        [Obsolete("AssemblyName members HashAlgorithm, ProcessorArchitecture, and VersionCompatibility are obsolete and not supported.", DiagnosticId = "SYSLIB0037", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public AssemblyVersionCompatibility VersionCompatibility { get; set; }
        [Obsolete("Strong name signing is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0017", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public StrongNameKeyPair KeyPair { get; set; }
        public string FullName { get; }

        public object Clone();
        public static AssemblyName GetAssemblyName(string assemblyFile);
        public byte[] GetPublicKey();
        public void SetPublicKey(byte[] publicKey);
        public byte[] GetPublicKeyToken();
        public void SetPublicKeyToken(byte[] publicKeyToken);
        public override string ToString();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public void GetObjectData(SerializationInfo info, StreamingContext context);
        public void OnDeserialization(object sender);
        public static bool ReferenceMatchesDefinition(AssemblyName reference, AssemblyName definition);
    }
}
