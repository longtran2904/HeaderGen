#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection
{
    public readonly struct CustomAttributeNamedArgument : IEquatable<CustomAttributeNamedArgument>
    {

        public CustomAttributeNamedArgument(MemberInfo memberInfo, object value);
        public CustomAttributeNamedArgument(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument);

        public MemberInfo MemberInfo { get; }
        public CustomAttributeTypedArgument TypedValue { get; }
        public string MemberName { get; }
        public bool IsField { get; }

        public override string ToString();
        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(CustomAttributeNamedArgument other);

        public static bool operator ==(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right);
        public static bool operator !=(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right);
    }
}
