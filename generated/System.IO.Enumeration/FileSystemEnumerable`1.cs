#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.Collections.Generic;

namespace System.IO.Enumeration
{
    public class FileSystemEnumerable<TResult> : IEnumerable, IEnumerable<TResult>
    {

        public FileSystemEnumerable(string directory, FindTransform transform, EnumerationOptions options = null);

        public FindPredicate ShouldIncludePredicate { get; set; }
        public FindPredicate ShouldRecursePredicate { get; set; }

        public IEnumerator<TResult> GetEnumerator();
        public delegate bool FindPredicate(ref FileSystemEntry entry);
        public delegate TResult FindTransform(ref FileSystemEntry entry);
    }
}
