#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection
{
    public sealed class NullabilityInfoContext
    {
        public NullabilityInfoContext();

        public NullabilityInfo Create(ParameterInfo parameterInfo);
        public NullabilityInfo Create(PropertyInfo propertyInfo);
        public NullabilityInfo Create(EventInfo eventInfo);
        public NullabilityInfo Create(FieldInfo fieldInfo);
    }
}
