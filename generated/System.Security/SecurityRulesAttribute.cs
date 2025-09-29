#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Security
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = False)]
    public sealed class SecurityRulesAttribute : Attribute
    {
        public SecurityRulesAttribute(SecurityRuleSet ruleSet);

        public bool SkipVerificationInFullTrust { get; set; }
        public SecurityRuleSet RuleSet { get; }
    }
}
