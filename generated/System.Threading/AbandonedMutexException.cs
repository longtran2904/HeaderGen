#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Threading
{
    public class AbandonedMutexException : SystemException
    {

        public AbandonedMutexException();
        public AbandonedMutexException(string message);
        public AbandonedMutexException(string message, Exception inner);
        public AbandonedMutexException(int location, WaitHandle handle);
        public AbandonedMutexException(string message, int location, WaitHandle handle);
        public AbandonedMutexException(string message, Exception inner, int location, WaitHandle handle);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected AbandonedMutexException(SerializationInfo info, StreamingContext context);

        public Mutex Mutex { get; }
        public int MutexIndex { get; }
    }
}
