#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.IO
{
    [Flags]
    public enum FileOptions
    {

        None = 0,
        WriteThrough = -2147483648,
        Asynchronous = 1073741824,
        RandomAccess = 268435456,
        DeleteOnClose = 67108864,
        SequentialScan = 134217728,
        Encrypted = 16384
    }
}
