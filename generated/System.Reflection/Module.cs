#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Reflection
{
    public abstract class Module : ICustomAttributeProvider, ISerializable
    {
        public static readonly TypeFilter FilterTypeName;
        public static readonly TypeFilter FilterTypeNameIgnoreCase;

        protected Module();

        public virtual Assembly Assembly { get; }
        public virtual string FullyQualifiedName { get; }
        public virtual string Name { get; }
        public virtual int MDStreamVersion { get; }
        public virtual Guid ModuleVersionId { get; }
        public virtual string ScopeName { get; }
        public ModuleHandle ModuleHandle { get; }
        public virtual IEnumerable<CustomAttributeData> CustomAttributes { get; }
        public virtual int MetadataToken { get; }

        public virtual void GetPEKind(out PortableExecutableKinds peKind, out ImageFileMachine machine);
        public virtual bool IsResource();
        public virtual bool IsDefined(Type attributeType, bool inherit);
        public virtual IList<CustomAttributeData> GetCustomAttributesData();
        public virtual object[] GetCustomAttributes(bool inherit);
        public virtual object[] GetCustomAttributes(Type attributeType, bool inherit);
        public MethodInfo GetMethod(string name);
        public MethodInfo GetMethod(string name, Type[] types);
        public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
        protected virtual MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
        public MethodInfo[] GetMethods();
        public virtual MethodInfo[] GetMethods(BindingFlags bindingFlags);
        public FieldInfo GetField(string name);
        public virtual FieldInfo GetField(string name, BindingFlags bindingAttr);
        public FieldInfo[] GetFields();
        public virtual FieldInfo[] GetFields(BindingFlags bindingFlags);
        public virtual Type[] GetTypes();
        public virtual Type GetType(string className);
        public virtual Type GetType(string className, bool ignoreCase);
        public virtual Type GetType(string className, bool throwOnError, bool ignoreCase);
        public virtual Type[] FindTypes(TypeFilter filter, object filterCriteria);
        public FieldInfo ResolveField(int metadataToken);
        public virtual FieldInfo ResolveField(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments);
        public MemberInfo ResolveMember(int metadataToken);
        public virtual MemberInfo ResolveMember(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments);
        public MethodBase ResolveMethod(int metadataToken);
        public virtual MethodBase ResolveMethod(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments);
        public virtual byte[] ResolveSignature(int metadataToken);
        public virtual string ResolveString(int metadataToken);
        public Type ResolveType(int metadataToken);
        public virtual Type ResolveType(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(Module left, Module right);
        public static bool operator !=(Module left, Module right);
    }
}
