#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime
{
    public struct DependentHandle : IDisposable
    {
        public DependentHandle(object target, object dependent);

        public bool IsAllocated { get; }
        public object Target { get; set; }
        public object Dependent { get; set; }
        public (object Target, object Dependent) TargetAndDependent { get; }

        public void Dispose();
    }
}
