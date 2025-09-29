#region System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Runtime.InteropServices.dll
#endregion

using System.Collections;

namespace System.Runtime.InteropServices.Marshalling
{
    [CLSCompliant(False)]
    public class StrategyBasedComWrappers : ComWrappers
    {

        public StrategyBasedComWrappers();

        public static IIUnknownInterfaceDetailsStrategy DefaultIUnknownInterfaceDetailsStrategy { get; }
        public static IIUnknownStrategy DefaultIUnknownStrategy { get; }

        protected static IIUnknownCacheStrategy CreateDefaultCacheStrategy();
        protected virtual IIUnknownInterfaceDetailsStrategy GetOrCreateInterfaceDetailsStrategy();
        protected virtual IIUnknownStrategy GetOrCreateIUnknownStrategy();
        protected virtual IIUnknownCacheStrategy CreateCacheStrategy();
        protected sealed override ComInterfaceEntry* ComputeVtables(object obj, CreateComInterfaceFlags flags, out int count);
        protected sealed override object CreateObject(nint externalComObject, CreateObjectFlags flags);
        protected sealed override void ReleaseObjects(IEnumerable objects);
    }
}
