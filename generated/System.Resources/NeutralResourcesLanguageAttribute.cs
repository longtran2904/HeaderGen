#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Resources
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = False)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class NeutralResourcesLanguageAttribute : Attribute
    {

        public NeutralResourcesLanguageAttribute(string cultureName);
        public NeutralResourcesLanguageAttribute(string cultureName, UltimateResourceFallbackLocation location);

        public string CultureName { get; }
        public UltimateResourceFallbackLocation Location { get; }
    }
}
