#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection
{
    public abstract class MethodInfo : MethodBase
    {

        protected MethodInfo();

        public override MemberTypes MemberType { get; }
        public virtual ParameterInfo ReturnParameter { get; }
        public virtual Type ReturnType { get; }
        public abstract ICustomAttributeProvider ReturnTypeCustomAttributes { get; }

        public override Type[] GetGenericArguments();
        public virtual MethodInfo GetGenericMethodDefinition();
        public virtual MethodInfo MakeGenericMethod(params Type[] typeArguments);
        public abstract MethodInfo GetBaseDefinition();
        public virtual Delegate CreateDelegate(Type delegateType);
        public virtual Delegate CreateDelegate(Type delegateType, object target);
        public T CreateDelegate<T>() where T : Delegate;
        public T CreateDelegate<T>(object target) where T : Delegate;
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(MethodInfo left, MethodInfo right);
        public static bool operator !=(MethodInfo left, MethodInfo right);
    }
}
