#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection
{
    public readonly struct CustomAttributeTypedArgument : IEquatable<CustomAttributeTypedArgument>
    {

        public CustomAttributeTypedArgument(Type argumentType, object value);
        public CustomAttributeTypedArgument(object value);

        public Type ArgumentType { get; }
        public object Value { get; }

        public override string ToString();
        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(CustomAttributeTypedArgument other);

        public static bool operator ==(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right);
        public static bool operator !=(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right);
    }
}
