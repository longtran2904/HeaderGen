#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Reflection
{
    public class CustomAttributeData
    {

        protected CustomAttributeData();

        public virtual Type AttributeType { get; }
        public virtual ConstructorInfo Constructor { get; }
        public virtual IList<CustomAttributeTypedArgument> ConstructorArguments { get; }
        public virtual IList<CustomAttributeNamedArgument> NamedArguments { get; }

        public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target);
        public static IList<CustomAttributeData> GetCustomAttributes(Module target);
        public static IList<CustomAttributeData> GetCustomAttributes(Assembly target);
        public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target);
        public override string ToString();
        public override int GetHashCode();
        public override bool Equals(object obj);
    }
}
