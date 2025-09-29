#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Globalization
{
    public class DaylightTime
    {

        public DaylightTime(DateTime start, DateTime end, TimeSpan delta);

        public DateTime Start { get; }
        public DateTime End { get; }
        public TimeSpan Delta { get; }
    }
}
