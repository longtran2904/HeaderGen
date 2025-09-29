#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Threading;

namespace System
{
    public class Lazy<T>
    {

        public Lazy();
        public Lazy(T value);
        public Lazy(Func<T> valueFactory);
        public Lazy(bool isThreadSafe);
        public Lazy(LazyThreadSafetyMode mode);
        public Lazy(Func<T> valueFactory, bool isThreadSafe);
        public Lazy(Func<T> valueFactory, LazyThreadSafetyMode mode);

        public bool IsValueCreated { get; }
        public T Value { get; }

        public override string ToString();
    }
}
