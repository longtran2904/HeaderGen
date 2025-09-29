#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil.Cil
{
    public sealed class ConstantDebugInformation : DebugInformation
    {
        public ConstantDebugInformation(string name, TypeReference constant_type, object value);

        public string Name { get; set; }
        public TypeReference ConstantType { get; set; }
        public object Value { get; set; }
    }
}
