#region System.IO.Pipes, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.IO.Pipes.dll
#endregion

namespace System.IO.Pipes
{
    [Flags]
    public enum PipeOptions
    {

        None = 0,
        WriteThrough = -2147483648,
        Asynchronous = 1073741824,
        CurrentUserOnly = 536870912,
        FirstPipeInstance = 524288
    }
}
