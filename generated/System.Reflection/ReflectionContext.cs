#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection
{
    public abstract class ReflectionContext
    {

        protected ReflectionContext();

        public abstract Assembly MapAssembly(Assembly assembly);
        public abstract TypeInfo MapType(TypeInfo type);
        public virtual TypeInfo GetTypeForObject(object value);
    }
}
