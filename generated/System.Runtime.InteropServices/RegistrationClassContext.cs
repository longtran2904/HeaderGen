#region System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Runtime.InteropServices.dll
#endregion

namespace System.Runtime.InteropServices
{
    [Flags]
    public enum RegistrationClassContext
    {
        InProcessServer = 1,
        InProcessHandler = 2,
        LocalServer = 4,
        InProcessServer16 = 8,
        RemoteServer = 16,
        InProcessHandler16 = 32,
        Reserved1 = 64,
        Reserved2 = 128,
        Reserved3 = 256,
        Reserved4 = 512,
        NoCodeDownload = 1024,
        Reserved5 = 2048,
        NoCustomMarshal = 4096,
        EnableCodeDownload = 8192,
        NoFailureLog = 16384,
        DisableActivateAsActivator = 32768,
        EnableActivateAsActivator = 65536,
        FromDefaultContext = 131072
    }
}
