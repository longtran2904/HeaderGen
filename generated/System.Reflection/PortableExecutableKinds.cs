#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection
{
    [Flags]
    public enum PortableExecutableKinds
    {

        NotAPortableExecutableImage = 0,
        ILOnly = 1,
        Required32Bit = 2,
        PE32Plus = 4,
        Unmanaged32Bit = 8,
        Preferred32Bit = 16
    }
}
