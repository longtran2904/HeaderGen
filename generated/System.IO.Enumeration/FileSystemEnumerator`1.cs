#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace System.IO.Enumeration
{
    public abstract class FileSystemEnumerator<TResult> : CriticalFinalizerObject, IDisposable, IEnumerator, IEnumerator<TResult>
    {
        public FileSystemEnumerator(string directory, EnumerationOptions options = null);

        ~FileSystemEnumerator();

        public TResult Current { get; }

        protected virtual bool ShouldIncludeEntry(ref FileSystemEntry entry);
        protected virtual bool ShouldRecurseIntoEntry(ref FileSystemEntry entry);
        protected abstract TResult TransformEntry(ref FileSystemEntry entry);
        protected virtual void OnDirectoryFinished(ReadOnlySpan<char> directory);
        protected virtual bool ContinueOnError(int error);
        public void Reset();
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        public bool MoveNext();
    }
}
