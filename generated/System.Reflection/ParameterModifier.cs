#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection
{
    [DefaultMember("Item")]
    public readonly struct ParameterModifier
    {

        public ParameterModifier(int parameterCount);

        public bool this[int index] { get; set; }
    }
}
