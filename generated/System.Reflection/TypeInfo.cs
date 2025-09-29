#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Reflection
{
    public abstract class TypeInfo : Type, IReflectableType
    {
        protected TypeInfo();

        public virtual Type[] GenericTypeParameters { get; }
        public virtual IEnumerable<ConstructorInfo> DeclaredConstructors { get; }
        public virtual IEnumerable<EventInfo> DeclaredEvents { get; }
        public virtual IEnumerable<FieldInfo> DeclaredFields { get; }
        public virtual IEnumerable<MemberInfo> DeclaredMembers { get; }
        public virtual IEnumerable<MethodInfo> DeclaredMethods { get; }
        public virtual IEnumerable<TypeInfo> DeclaredNestedTypes { get; }
        public virtual IEnumerable<PropertyInfo> DeclaredProperties { get; }
        public virtual IEnumerable<Type> ImplementedInterfaces { get; }

        public virtual Type AsType();
        public virtual EventInfo GetDeclaredEvent(string name);
        public virtual FieldInfo GetDeclaredField(string name);
        public virtual MethodInfo GetDeclaredMethod(string name);
        public virtual TypeInfo GetDeclaredNestedType(string name);
        public virtual PropertyInfo GetDeclaredProperty(string name);
        public virtual IEnumerable<MethodInfo> GetDeclaredMethods(string name);
        public virtual bool IsAssignableFrom(TypeInfo typeInfo);
    }
}
