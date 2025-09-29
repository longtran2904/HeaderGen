#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

namespace System.Security.AccessControl
{
    public abstract class QualifiedAce : KnownAce
    {
        public AceQualifier AceQualifier { get; }
        public bool IsCallback { get; }
        public int OpaqueLength { get; }

        public byte[] GetOpaque();
        public void SetOpaque(byte[] opaque);
    }
}
