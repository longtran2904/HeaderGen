#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Reflection
{
    public static class RuntimeReflectionExtensions
    {
        public static IEnumerable<FieldInfo> GetRuntimeFields(this Type type);
        public static IEnumerable<MethodInfo> GetRuntimeMethods(this Type type);
        public static IEnumerable<PropertyInfo> GetRuntimeProperties(this Type type);
        public static IEnumerable<EventInfo> GetRuntimeEvents(this Type type);
        public static FieldInfo GetRuntimeField(this Type type, string name);
        public static MethodInfo GetRuntimeMethod(this Type type, string name, Type[] parameters);
        public static PropertyInfo GetRuntimeProperty(this Type type, string name);
        public static EventInfo GetRuntimeEvent(this Type type, string name);
        public static MethodInfo GetRuntimeBaseDefinition(this MethodInfo method);
        public static InterfaceMapping GetRuntimeInterfaceMap(this TypeInfo typeInfo, Type interfaceType);
        public static MethodInfo GetMethodInfo(this Delegate del);
    }
}
