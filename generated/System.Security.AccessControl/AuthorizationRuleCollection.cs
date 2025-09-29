#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

using System.Collections;
using System.Reflection;

namespace System.Security.AccessControl
{
    [DefaultMember("Item")]
    public sealed class AuthorizationRuleCollection : ReadOnlyCollectionBase
    {

        public AuthorizationRuleCollection();

        public AuthorizationRule this[int index] { get; }

        public void AddRule(AuthorizationRule rule);
        public void CopyTo(AuthorizationRule[] rules, int index);
    }
}
