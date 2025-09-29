#region System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Runtime.InteropServices.dll
#endregion

namespace System.Runtime.InteropServices
{
    [Flags]
    public enum RegistrationConnectionType
    {

        SingleUse = 0,
        MultipleUse = 1,
        MultiSeparate = 2,
        Suspended = 4,
        Surrogate = 8
    }
}
