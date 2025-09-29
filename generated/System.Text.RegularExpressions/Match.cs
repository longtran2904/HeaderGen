#region System.Text.RegularExpressions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Text.RegularExpressions.dll
#endregion

namespace System.Text.RegularExpressions
{
    public class Match : Group
    {
        public static Match Empty { get; }
        public virtual GroupCollection Groups { get; }

        public Match NextMatch();
        public virtual string Result(string replacement);
        public static Match Synchronized(Match inner);
    }
}
