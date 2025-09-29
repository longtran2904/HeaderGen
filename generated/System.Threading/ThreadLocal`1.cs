#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Threading
{
    public class ThreadLocal<T> : IDisposable
    {

        public ThreadLocal();
        public ThreadLocal(bool trackAllValues);
        public ThreadLocal(Func<T> valueFactory);
        public ThreadLocal(Func<T> valueFactory, bool trackAllValues);

        ~ThreadLocal();

        public T Value { get; set; }
        public IList<T> Values { get; }
        public bool IsValueCreated { get; }

        public void Dispose();
        protected virtual void Dispose(bool disposing);
        public override string ToString();
    }
}
