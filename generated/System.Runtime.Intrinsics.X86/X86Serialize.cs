#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.X86
{
    [CLSCompliant(False)]
    public abstract class X86Serialize : X86Base
    {

        public static bool IsSupported { get; }

        public static void Serialize();
        public abstract class X64 : X86Base.X64
        {

            public static bool IsSupported { get; }
        }
    }
}
