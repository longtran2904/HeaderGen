#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices.Marshalling
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = True)]
    public sealed class MarshalUsingAttribute : Attribute
    {

        public const string ReturnsCountValue = "return-value";

        public MarshalUsingAttribute();
        public MarshalUsingAttribute(Type nativeType);

        public Type NativeType { get; }
        public string CountElementName { get; set; }
        public int ConstantElementCount { get; set; }
        public int ElementIndirectionDepth { get; set; }
    }
}
