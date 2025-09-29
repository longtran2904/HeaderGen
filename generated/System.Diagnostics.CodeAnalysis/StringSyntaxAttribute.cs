#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = False, Inherited = False)]
    public sealed class StringSyntaxAttribute : Attribute
    {
        public const string CompositeFormat = "CompositeFormat";
        public const string DateOnlyFormat = "DateOnlyFormat";
        public const string DateTimeFormat = "DateTimeFormat";
        public const string EnumFormat = "EnumFormat";
        public const string GuidFormat = "GuidFormat";
        public const string Json = "Json";
        public const string NumericFormat = "NumericFormat";
        public const string Regex = "Regex";
        public const string TimeOnlyFormat = "TimeOnlyFormat";
        public const string TimeSpanFormat = "TimeSpanFormat";
        public const string Uri = "Uri";
        public const string Xml = "Xml";

        public StringSyntaxAttribute(string syntax);
        public StringSyntaxAttribute(string syntax, params object[] arguments);

        public string Syntax { get; }
        public object[] Arguments { get; }
    }
}
