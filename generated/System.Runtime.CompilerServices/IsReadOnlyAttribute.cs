#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.All, Inherited = False)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class IsReadOnlyAttribute : Attribute
    {

        public IsReadOnlyAttribute();
    }
}
