#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.IO
{
    public abstract class FileSystemInfo : MarshalByRefObject, ISerializable
    {

        protected string FullPath;
        protected string OriginalPath;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected FileSystemInfo(SerializationInfo info, StreamingContext context);
        protected FileSystemInfo();

        public virtual string FullName { get; }
        public string Extension { get; }
        public abstract string Name { get; }
        public abstract bool Exists { get; }
        public DateTime CreationTime { get; set; }
        public DateTime CreationTimeUtc { get; set; }
        public DateTime LastAccessTime { get; set; }
        public DateTime LastAccessTimeUtc { get; set; }
        public DateTime LastWriteTime { get; set; }
        public DateTime LastWriteTimeUtc { get; set; }
        public string LinkTarget { get; }
        public UnixFileMode UnixFileMode { get; set; }
        public FileAttributes Attributes { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
        public abstract void Delete();
        public void CreateAsSymbolicLink(string pathToTarget);
        public FileSystemInfo ResolveLinkTarget(bool returnFinalTarget);
        public override string ToString();
        public void Refresh();
    }
}
