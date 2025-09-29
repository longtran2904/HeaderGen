#region System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Runtime.InteropServices.dll
#endregion

using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Versioning;

namespace System.Runtime.InteropServices
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class ComAwareEventInfo : EventInfo
    {

        public ComAwareEventInfo(Type type, string eventName);

        public override EventAttributes Attributes { get; }
        public override Type DeclaringType { get; }
        public override int MetadataToken { get; }
        public override Module Module { get; }
        public override string Name { get; }
        public override Type ReflectedType { get; }

        [SupportedOSPlatform("windows")]
        public override void AddEventHandler(object target, Delegate handler);
        [SupportedOSPlatform("windows")]
        public override void RemoveEventHandler(object target, Delegate handler);
        public override MethodInfo GetAddMethod(bool nonPublic);
        public override MethodInfo[] GetOtherMethods(bool nonPublic);
        public override MethodInfo GetRaiseMethod(bool nonPublic);
        public override MethodInfo GetRemoveMethod(bool nonPublic);
        public override object[] GetCustomAttributes(Type attributeType, bool inherit);
        public override object[] GetCustomAttributes(bool inherit);
        public override IList<CustomAttributeData> GetCustomAttributesData();
        public override bool IsDefined(Type attributeType, bool inherit);
    }
}
