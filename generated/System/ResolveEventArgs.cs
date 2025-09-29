#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System
{
    public class ResolveEventArgs : EventArgs
    {
        public ResolveEventArgs(string name);
        public ResolveEventArgs(string name, Assembly requestingAssembly);

        public string Name { get; }
        public Assembly RequestingAssembly { get; }
    }
}
