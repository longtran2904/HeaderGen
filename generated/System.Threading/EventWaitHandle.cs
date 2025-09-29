#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Versioning;

namespace System.Threading
{
    public class EventWaitHandle : WaitHandle
    {
        public EventWaitHandle(bool initialState, EventResetMode mode);
        public EventWaitHandle(bool initialState, EventResetMode mode, string name);
        public EventWaitHandle(bool initialState, EventResetMode mode, string name, out bool createdNew);

        [SupportedOSPlatform("windows")]
        public static EventWaitHandle OpenExisting(string name);
        [SupportedOSPlatform("windows")]
        public static bool TryOpenExisting(string name, out EventWaitHandle result);
        public bool Reset();
        public bool Set();
    }
}
