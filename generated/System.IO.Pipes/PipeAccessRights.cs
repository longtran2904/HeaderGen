#region System.IO.Pipes, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.IO.Pipes.dll
#endregion

namespace System.IO.Pipes
{
    [Flags]
    public enum PipeAccessRights
    {
        ReadData = 1,
        WriteData = 2,
        ReadAttributes = 128,
        WriteAttributes = 256,
        ReadExtendedAttributes = 8,
        WriteExtendedAttributes = 16,
        CreateNewInstance = 4,
        Delete = 65536,
        ReadPermissions = 131072,
        ChangePermissions = 262144,
        TakeOwnership = 524288,
        Synchronize = 1048576,
        FullControl = 2032031,
        Read = 131209,
        Write = 274,
        ReadWrite = 131483,
        AccessSystemSecurity = 16777216
    }
}
