#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = True, Inherited = False)]
    [Conditional("CODE_ANALYSIS")]
    public sealed class SuppressMessageAttribute : Attribute
    {

        public SuppressMessageAttribute(string category, string checkId);

        public string Category { get; }
        public string CheckId { get; }
        public string Scope { get; set; }
        public string Target { get; set; }
        public string MessageId { get; set; }
        public string Justification { get; set; }
    }
}
