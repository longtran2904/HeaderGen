#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Reflection
{
    public class ParameterInfo : ICustomAttributeProvider, IObjectReference
    {

        protected ParameterAttributes AttrsImpl;
        protected Type ClassImpl;
        protected object DefaultValueImpl;
        protected MemberInfo MemberImpl;
        protected string NameImpl;
        protected int PositionImpl;

        protected ParameterInfo();

        public virtual ParameterAttributes Attributes { get; }
        public virtual MemberInfo Member { get; }
        public virtual string Name { get; }
        public virtual Type ParameterType { get; }
        public virtual int Position { get; }
        public bool IsIn { get; }
        public bool IsLcid { get; }
        public bool IsOptional { get; }
        public bool IsOut { get; }
        public bool IsRetval { get; }
        public virtual object DefaultValue { get; }
        public virtual object RawDefaultValue { get; }
        public virtual bool HasDefaultValue { get; }
        public virtual IEnumerable<CustomAttributeData> CustomAttributes { get; }
        public virtual int MetadataToken { get; }

        public virtual bool IsDefined(Type attributeType, bool inherit);
        public virtual IList<CustomAttributeData> GetCustomAttributesData();
        public virtual object[] GetCustomAttributes(bool inherit);
        public virtual object[] GetCustomAttributes(Type attributeType, bool inherit);
        public virtual Type GetModifiedParameterType();
        public virtual Type[] GetOptionalCustomModifiers();
        public virtual Type[] GetRequiredCustomModifiers();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public object GetRealObject(StreamingContext context);
        public override string ToString();
    }
}
