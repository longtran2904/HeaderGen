#region System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Runtime.InteropServices.dll
#endregion

using System.Runtime.Versioning;

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = False)]
    [SupportedOSPlatform("windows")]
    public sealed class IDispatchConstantAttribute : CustomConstantAttribute
    {

        public IDispatchConstantAttribute();

        public override object Value { get; }
    }
}
