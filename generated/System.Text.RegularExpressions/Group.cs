#region System.Text.RegularExpressions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Text.RegularExpressions.dll
#endregion

namespace System.Text.RegularExpressions
{
    public class Group : Capture
    {
        public bool Success { get; }
        public string Name { get; }
        public CaptureCollection Captures { get; }

        public static Group Synchronized(Group inner);
    }
}
