#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics
{
    public static class StackFrameExtensions
    {

        public static bool HasNativeImage(this StackFrame stackFrame);
        public static bool HasMethod(this StackFrame stackFrame);
        public static bool HasILOffset(this StackFrame stackFrame);
        public static bool HasSource(this StackFrame stackFrame);
        public static nint GetNativeIP(this StackFrame stackFrame);
        public static nint GetNativeImageBase(this StackFrame stackFrame);
    }
}
