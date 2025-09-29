#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field, AllowMultiple = True, Inherited = False)]
    public sealed class DynamicDependencyAttribute : Attribute
    {

        public DynamicDependencyAttribute(string memberSignature);
        public DynamicDependencyAttribute(string memberSignature, Type type);
        public DynamicDependencyAttribute(string memberSignature, string typeName, string assemblyName);
        public DynamicDependencyAttribute(DynamicallyAccessedMemberTypes memberTypes, Type type);
        public DynamicDependencyAttribute(DynamicallyAccessedMemberTypes memberTypes, string typeName, string assemblyName);

        public string MemberSignature { get; }
        public DynamicallyAccessedMemberTypes MemberTypes { get; }
        public Type Type { get; }
        public string TypeName { get; }
        public string AssemblyName { get; }
        public string Condition { get; set; }
    }
}
