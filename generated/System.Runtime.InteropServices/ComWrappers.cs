#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.Runtime.Versioning;

namespace System.Runtime.InteropServices
{
    [CLSCompliant(False)]
    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public abstract class ComWrappers
    {
        protected ComWrappers();

        public static bool TryGetComInstance(object obj, out nint unknown);
        public static bool TryGetObject(nint unknown, out object obj);
        public nint GetOrCreateComInterfaceForObject(object instance, CreateComInterfaceFlags flags);
        public object GetOrCreateObjectForComInstance(nint externalComObject, CreateObjectFlags flags);
        public object GetOrRegisterObjectForComInstance(nint externalComObject, CreateObjectFlags flags, object wrapper);
        public object GetOrRegisterObjectForComInstance(nint externalComObject, CreateObjectFlags flags, object wrapper, nint inner);
        public static void RegisterForTrackerSupport(ComWrappers instance);
        [SupportedOSPlatform("windows")]
        public static void RegisterForMarshalling(ComWrappers instance);
        public static void GetIUnknownImpl(out nint fpQueryInterface, out nint fpAddRef, out nint fpRelease);
        protected abstract ComInterfaceEntry* ComputeVtables(object obj, CreateComInterfaceFlags flags, out int count);
        protected abstract object CreateObject(nint externalComObject, CreateObjectFlags flags);
        protected abstract void ReleaseObjects(IEnumerable objects);

        public struct ComInterfaceDispatch
        {
            public nint Vtable;

            public static T GetInstance<T>(ComInterfaceDispatch* dispatchPtr) where T : class;
        }
        public struct ComInterfaceEntry
        {
            public Guid IID;
            public nint Vtable;
        }
    }
}
