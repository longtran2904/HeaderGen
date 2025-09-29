#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

namespace System.Security.AccessControl
{
    [Flags]
    public enum AceFlags
    {

        None = 0,
        ObjectInherit = 1,
        ContainerInherit = 2,
        NoPropagateInherit = 4,
        InheritOnly = 8,
        Inherited = 16,
        SuccessfulAccess = 64,
        FailedAccess = 128,
        InheritanceFlags = 15,
        AuditFlags = 192
    }
}
