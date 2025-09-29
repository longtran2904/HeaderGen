#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;

namespace System
{
    public abstract class Delegate : ICloneable, ISerializable
    {

        protected Delegate(object target, string method);
        protected Delegate(Type target, string method);

        public object Target { get; }
        public MethodInfo Method { get; }

        protected virtual object DynamicInvokeImpl(object[] args);
        public override bool Equals(object obj);
        public override int GetHashCode();
        protected virtual MethodInfo GetMethodImpl();
        public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure);
        public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure);
        public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure);
        public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure);
        public virtual object Clone();
        public static Delegate Combine(Delegate a, Delegate b);
        public static Delegate Combine(params Delegate[] delegates);
        public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method);
        public static Delegate CreateDelegate(Type type, MethodInfo method);
        public static Delegate CreateDelegate(Type type, object target, string method);
        public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase);
        public static Delegate CreateDelegate(Type type, Type target, string method);
        public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase);
        protected virtual Delegate CombineImpl(Delegate d);
        protected virtual Delegate RemoveImpl(Delegate d);
        public virtual Delegate[] GetInvocationList();
        public object DynamicInvoke(params object[] args);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
        public static Delegate Remove(Delegate source, Delegate value);
        public static Delegate RemoveAll(Delegate source, Delegate value);

        public static bool operator ==(Delegate d1, Delegate d2);
        public static bool operator !=(Delegate d1, Delegate d2);
    }
}
