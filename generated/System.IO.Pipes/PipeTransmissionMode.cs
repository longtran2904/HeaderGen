#region System.IO.Pipes, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.IO.Pipes.dll
#endregion

using System.Runtime.Versioning;

namespace System.IO.Pipes
{
    public enum PipeTransmissionMode
    {

        Byte = 0,
        [SupportedOSPlatform("windows")]
        Message = 1
    }
}
