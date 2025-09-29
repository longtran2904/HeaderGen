#region System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.ObjectModel.dll
#endregion

namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.All)]
    public sealed class TypeConverterAttribute : Attribute
    {
        public static readonly TypeConverterAttribute Default;

        public TypeConverterAttribute();
        public TypeConverterAttribute(Type type);
        public TypeConverterAttribute(string typeName);

        public string ConverterTypeName { get; }

        public override bool Equals(object obj);
        public override int GetHashCode();
    }
}
