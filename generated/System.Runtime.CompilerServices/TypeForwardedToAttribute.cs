#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = True, Inherited = False)]
    public sealed class TypeForwardedToAttribute : Attribute
    {
        public TypeForwardedToAttribute(Type destination);

        public Type Destination { get; }
    }
}
