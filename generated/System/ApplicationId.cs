#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public sealed class ApplicationId
    {

        public ApplicationId(byte[] publicKeyToken, string name, Version version, string processorArchitecture, string culture);

        public string Culture { get; }
        public string Name { get; }
        public string ProcessorArchitecture { get; }
        public Version Version { get; }
        public byte[] PublicKeyToken { get; }

        public ApplicationId Copy();
        public override string ToString();
        public override bool Equals(object o);
        public override int GetHashCode();
    }
}
