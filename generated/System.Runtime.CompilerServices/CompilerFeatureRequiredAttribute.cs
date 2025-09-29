#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = True, Inherited = False)]
    public sealed class CompilerFeatureRequiredAttribute : Attribute
    {

        public const string RefStructs = "RefStructs";
        public const string RequiredMembers = "RequiredMembers";

        public CompilerFeatureRequiredAttribute(string featureName);

        public string FeatureName { get; }
        public bool IsOptional { get; set; }
    }
}
