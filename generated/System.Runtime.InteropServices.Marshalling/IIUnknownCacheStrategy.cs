#region System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Runtime.InteropServices.dll
#endregion

namespace System.Runtime.InteropServices.Marshalling
{
    [CLSCompliant(False)]
    public interface IIUnknownCacheStrategy
    {

        TableInfo ConstructTableInfo(RuntimeTypeHandle handle, IIUnknownDerivedDetails interfaceDetails, void* ptr);
        bool TryGetTableInfo(RuntimeTypeHandle handle, out TableInfo info);
        bool TrySetTableInfo(RuntimeTypeHandle handle, TableInfo info);
        void Clear(IIUnknownStrategy unknownStrategy);
        struct TableInfo
        {

            public void* ThisPtr { get; set; }
            public void** Table { get; set; }
            public RuntimeTypeHandle ManagedType { get; set; }
        }
    }
}
