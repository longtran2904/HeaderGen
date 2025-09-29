#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection.Metadata
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = True)]
    public sealed class MetadataUpdateHandlerAttribute : Attribute
    {

        public MetadataUpdateHandlerAttribute(Type handlerType);

        public Type HandlerType { get; }
    }
}
