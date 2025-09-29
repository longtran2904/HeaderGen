#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;

namespace System.Reflection.Emit
{
    public sealed class DynamicMethod : MethodInfo
    {
        public DynamicMethod(string name, Type returnType, Type[] parameterTypes);
        public DynamicMethod(string name, Type returnType, Type[] parameterTypes, bool restrictedSkipVisibility);
        public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Module m);
        public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Module m, bool skipVisibility);
        public DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Module m, bool skipVisibility);
        public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner);
        public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility);
        public DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility);

        public override string Name { get; }
        public override Type DeclaringType { get; }
        public override Type ReflectedType { get; }
        public override Module Module { get; }
        public override RuntimeMethodHandle MethodHandle { get; }
        public override MethodAttributes Attributes { get; }
        public override CallingConventions CallingConvention { get; }
        public override bool IsSecurityCritical { get; }
        public override bool IsSecuritySafeCritical { get; }
        public override bool IsSecurityTransparent { get; }
        public override Type ReturnType { get; }
        public override ParameterInfo ReturnParameter { get; }
        public override ICustomAttributeProvider ReturnTypeCustomAttributes { get; }
        public bool InitLocals { get; set; }

        public sealed override Delegate CreateDelegate(Type delegateType);
        public sealed override Delegate CreateDelegate(Type delegateType, object target);
        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);
        public DynamicILInfo GetDynamicILInfo();
        public ILGenerator GetILGenerator(int streamSize);
        public override string ToString();
        public override MethodInfo GetBaseDefinition();
        public override ParameterInfo[] GetParameters();
        public override MethodImplAttributes GetMethodImplementationFlags();
        public override object[] GetCustomAttributes(Type attributeType, bool inherit);
        public override object[] GetCustomAttributes(bool inherit);
        public override bool IsDefined(Type attributeType, bool inherit);
        public ParameterBuilder DefineParameter(int position, ParameterAttributes attributes, string parameterName);
        public ILGenerator GetILGenerator();
    }
}
