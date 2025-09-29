#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.ExceptionServices
{
    public sealed class ExceptionDispatchInfo
    {

        public Exception SourceException { get; }

        public static ExceptionDispatchInfo Capture(Exception source);
        public void Throw();
        public static void Throw(Exception source);
        public static Exception SetCurrentStackTrace(Exception source);
        public static Exception SetRemoteStackTrace(Exception source, string stackTrace);
    }
}
