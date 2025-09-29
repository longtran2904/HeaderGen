#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public class Progress<T> : IProgress<T>
    {

        public Progress();
        public Progress(Action<T> handler);

        public event EventHandler<T> ProgressChanged;

        protected virtual void OnReport(T value);
    }
}
