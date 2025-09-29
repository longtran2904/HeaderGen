#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices.Marshalling
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = True)]
    public sealed class CustomMarshallerAttribute : Attribute
    {

        public CustomMarshallerAttribute(Type managedType, MarshalMode marshalMode, Type marshallerType);

        public Type ManagedType { get; }
        public MarshalMode MarshalMode { get; }
        public Type MarshallerType { get; }
        public struct GenericPlaceholder
        {
        }
    }
}
