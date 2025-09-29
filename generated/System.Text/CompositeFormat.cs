#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Text
{
    public sealed class CompositeFormat
    {
        public string Format { get; }
        public int MinimumArgumentCount { get; }

        public static CompositeFormat Parse(string format);
    }
}
