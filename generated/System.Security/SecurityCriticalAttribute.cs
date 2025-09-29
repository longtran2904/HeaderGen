#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Security
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = False, Inherited = False)]
    public sealed class SecurityCriticalAttribute : Attribute
    {

        public SecurityCriticalAttribute();
        public SecurityCriticalAttribute(SecurityCriticalScope scope);

        [Obsolete("SecurityCriticalScope is only used for .NET 2.0 transparency compatibility.")]
        public SecurityCriticalScope Scope { get; }
    }
}
