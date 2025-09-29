#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
    public static class WaitHandleExtensions
    {

        public static SafeWaitHandle GetSafeWaitHandle(this WaitHandle waitHandle);
        public static void SetSafeWaitHandle(this WaitHandle waitHandle, SafeWaitHandle value);
    }
}
