#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Runtime.InteropServices
{
    [AttributeUsage(AttributeTargets.Class, Inherited = True)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class ComSourceInterfacesAttribute : Attribute
    {

        public ComSourceInterfacesAttribute(string sourceInterfaces);
        public ComSourceInterfacesAttribute(Type sourceInterface);
        public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2);
        public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2, Type sourceInterface3);
        public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2, Type sourceInterface3, Type sourceInterface4);

        public string Value { get; }
    }
}
