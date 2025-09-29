#region System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.ObjectModel.dll
#endregion

namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.Class, Inherited = True)]
    public sealed class TypeDescriptionProviderAttribute : Attribute
    {

        public TypeDescriptionProviderAttribute(string typeName);
        public TypeDescriptionProviderAttribute(Type type);

        public string TypeName { get; }
    }
}
