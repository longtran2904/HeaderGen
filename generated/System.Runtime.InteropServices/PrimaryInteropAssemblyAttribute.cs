#region System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Runtime.InteropServices.dll
#endregion

namespace System.Runtime.InteropServices
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = True, Inherited = False)]
    public sealed class PrimaryInteropAssemblyAttribute : Attribute
    {

        public PrimaryInteropAssemblyAttribute(int major, int minor);

        public int MajorVersion { get; }
        public int MinorVersion { get; }
    }
}
