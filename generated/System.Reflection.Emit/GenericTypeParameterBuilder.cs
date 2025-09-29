#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection.Emit
{
    public abstract class GenericTypeParameterBuilder : TypeInfo
    {

        protected GenericTypeParameterBuilder();

        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
        protected abstract void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
        public void SetBaseTypeConstraint(Type baseTypeConstraint);
        protected abstract void SetBaseTypeConstraintCore(Type baseTypeConstraint);
        public void SetInterfaceConstraints(params Type[] interfaceConstraints);
        protected abstract void SetInterfaceConstraintsCore(params Type[] interfaceConstraints);
        public void SetGenericParameterAttributes(GenericParameterAttributes genericParameterAttributes);
        protected abstract void SetGenericParameterAttributesCore(GenericParameterAttributes genericParameterAttributes);
    }
}
