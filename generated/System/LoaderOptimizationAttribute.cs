#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class LoaderOptimizationAttribute : Attribute
    {
        public LoaderOptimizationAttribute(byte value);
        public LoaderOptimizationAttribute(LoaderOptimization value);

        public LoaderOptimization Value { get; }
    }
}
