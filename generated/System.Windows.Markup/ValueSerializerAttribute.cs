#region System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.ObjectModel.dll
#endregion

namespace System.Windows.Markup
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = False, Inherited = True)]
    public sealed class ValueSerializerAttribute : Attribute
    {
        public ValueSerializerAttribute(Type valueSerializerType);
        public ValueSerializerAttribute(string valueSerializerTypeName);

        public Type ValueSerializerType { get; }
        public string ValueSerializerTypeName { get; }
    }
}
