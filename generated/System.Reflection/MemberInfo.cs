#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Reflection
{
    public abstract class MemberInfo : ICustomAttributeProvider
    {
        protected MemberInfo();

        public abstract MemberTypes MemberType { get; }
        public abstract string Name { get; }
        public abstract Type DeclaringType { get; }
        public abstract Type ReflectedType { get; }
        public virtual Module Module { get; }
        public virtual IEnumerable<CustomAttributeData> CustomAttributes { get; }
        public virtual bool IsCollectible { get; }
        public virtual int MetadataToken { get; }

        public virtual bool HasSameMetadataDefinitionAs(MemberInfo other);
        public abstract bool IsDefined(Type attributeType, bool inherit);
        public abstract object[] GetCustomAttributes(bool inherit);
        public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);
        public virtual IList<CustomAttributeData> GetCustomAttributesData();
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(MemberInfo left, MemberInfo right);
        public static bool operator !=(MemberInfo left, MemberInfo right);
    }
}
