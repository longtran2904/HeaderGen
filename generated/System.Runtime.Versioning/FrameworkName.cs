#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Versioning
{
    public sealed class FrameworkName : IEquatable<FrameworkName>
    {

        public FrameworkName(string identifier, Version version);
        public FrameworkName(string identifier, Version version, string profile);
        public FrameworkName(string frameworkName);

        public string Identifier { get; }
        public Version Version { get; }
        public string Profile { get; }
        public string FullName { get; }

        public override bool Equals(object obj);
        public bool Equals(FrameworkName other);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(FrameworkName left, FrameworkName right);
        public static bool operator !=(FrameworkName left, FrameworkName right);
    }
}
