#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = True, Inherited = False)]
    public sealed class ObfuscationAttribute : Attribute
    {

        public ObfuscationAttribute();

        public bool StripAfterObfuscation { get; set; }
        public bool Exclude { get; set; }
        public bool ApplyToMembers { get; set; }
        public string Feature { get; set; }
    }
}
