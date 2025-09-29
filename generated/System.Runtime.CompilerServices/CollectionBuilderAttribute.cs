#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, Inherited = False)]
    public sealed class CollectionBuilderAttribute : Attribute
    {

        public CollectionBuilderAttribute(Type builderType, string methodName);

        public Type BuilderType { get; }
        public string MethodName { get; }
    }
}
