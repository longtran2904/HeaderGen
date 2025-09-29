#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Threading.Tasks
{
    public static class TaskExtensions
    {

        public static Task Unwrap(this Task<Task> task);
        public static Task<TResult> Unwrap<TResult>(this Task<Task<TResult>> task);
    }
}
