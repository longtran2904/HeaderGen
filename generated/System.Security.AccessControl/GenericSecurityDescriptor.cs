#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

using System.Security.Principal;

namespace System.Security.AccessControl
{
    public abstract class GenericSecurityDescriptor
    {
        public static byte Revision { get; }
        public abstract ControlFlags ControlFlags { get; }
        public abstract SecurityIdentifier Owner { get; set; }
        public abstract SecurityIdentifier Group { get; set; }
        public int BinaryLength { get; }

        public static bool IsSddlConversionSupported();
        public string GetSddlForm(AccessControlSections includeSections);
        public void GetBinaryForm(byte[] binaryForm, int offset);
    }
}
