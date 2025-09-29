#region System.Text.RegularExpressions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Text.RegularExpressions.dll
#endregion

using System.ComponentModel;

namespace System.Text.RegularExpressions
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class RegexRunnerFactory
    {
        protected RegexRunnerFactory();

        protected internal abstract RegexRunner CreateInstance();
    }
}
