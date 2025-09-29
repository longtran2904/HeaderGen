#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Reflection;
using System.Runtime.Remoting;

namespace System
{
    public static class Activator
    {
        public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture);
        public static object CreateInstance(Type type, params object[] args);
        public static object CreateInstance(Type type, object[] args, object[] activationAttributes);
        public static object CreateInstance(Type type);
        public static ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName);
        public static ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes);
        public static ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
        public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
        public static ObjectHandle CreateInstance(string assemblyName, string typeName);
        public static ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
        public static ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes);
        public static object CreateInstance(Type type, bool nonPublic);
        public static T CreateInstance<T>();
    }
}
