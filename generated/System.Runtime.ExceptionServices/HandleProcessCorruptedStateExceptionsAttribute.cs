#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.ExceptionServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = False, Inherited = False)]
    [Obsolete("Recovery from corrupted process state exceptions is not supported; HandleProcessCorruptedStateExceptionsAttribute is ignored.", DiagnosticId = "SYSLIB0032", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
    public sealed class HandleProcessCorruptedStateExceptionsAttribute : Attribute
    {
        public HandleProcessCorruptedStateExceptionsAttribute();
    }
}
