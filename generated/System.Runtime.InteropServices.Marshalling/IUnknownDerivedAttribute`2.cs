#region System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Runtime.InteropServices.dll
#endregion

namespace System.Runtime.InteropServices.Marshalling
{
    [AttributeUsage(AttributeTargets.Interface, Inherited = False)]
    [CLSCompliant(False)]
    public class IUnknownDerivedAttribute<T, TImpl> : Attribute, IIUnknownDerivedDetails where T : IIUnknownInterfaceType
    {
        public IUnknownDerivedAttribute();

        public Guid Iid { get; }
        public Type Implementation { get; }
        public void** ManagedVirtualMethodTable { get; }
    }
}
