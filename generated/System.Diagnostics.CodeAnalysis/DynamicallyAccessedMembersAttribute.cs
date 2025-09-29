#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, Inherited = False)]
    public sealed class DynamicallyAccessedMembersAttribute : Attribute
    {

        public DynamicallyAccessedMembersAttribute(DynamicallyAccessedMemberTypes memberTypes);

        public DynamicallyAccessedMemberTypes MemberTypes { get; }
    }
}
