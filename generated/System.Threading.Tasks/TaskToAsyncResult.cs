#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Threading.Tasks
{
    public static class TaskToAsyncResult
    {
        public static IAsyncResult Begin(Task task, AsyncCallback callback, object state);
        public static void End(IAsyncResult asyncResult);
        public static TResult End<TResult>(IAsyncResult asyncResult);
        public static Task Unwrap(IAsyncResult asyncResult);
        public static Task<TResult> Unwrap<TResult>(IAsyncResult asyncResult);
    }
}
