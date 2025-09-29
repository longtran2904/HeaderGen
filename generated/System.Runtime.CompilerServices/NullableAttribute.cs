#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, Inherited = False)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class NullableAttribute : Attribute
    {

        public readonly byte[] NullableFlags;

        public NullableAttribute(byte value);
        public NullableAttribute(byte[] value);
    }
}
