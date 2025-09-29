#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Threading;

namespace System
{
    public class Lazy<T, TMetadata> : Lazy<T>
    {
        public Lazy(Func<T> valueFactory, TMetadata metadata);
        public Lazy(TMetadata metadata);
        public Lazy(TMetadata metadata, bool isThreadSafe);
        public Lazy(Func<T> valueFactory, TMetadata metadata, bool isThreadSafe);
        public Lazy(TMetadata metadata, LazyThreadSafetyMode mode);
        public Lazy(Func<T> valueFactory, TMetadata metadata, LazyThreadSafetyMode mode);

        public TMetadata Metadata { get; }
    }
}
