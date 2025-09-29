#region System.Console, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Console.dll
#endregion

namespace System
{
    public readonly struct ConsoleKeyInfo : IEquatable<ConsoleKeyInfo>
    {

        public ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control);

        public char KeyChar { get; }
        public ConsoleKey Key { get; }
        public ConsoleModifiers Modifiers { get; }

        public override bool Equals(object value);
        public bool Equals(ConsoleKeyInfo obj);
        public override int GetHashCode();

        public static bool operator ==(ConsoleKeyInfo a, ConsoleKeyInfo b);
        public static bool operator !=(ConsoleKeyInfo a, ConsoleKeyInfo b);
    }
}
