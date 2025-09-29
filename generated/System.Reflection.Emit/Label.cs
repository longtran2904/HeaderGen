#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection.Emit
{
    public readonly struct Label : IEquatable<Label>
    {

        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(Label obj);

        public static bool operator ==(Label a, Label b);
        public static bool operator !=(Label a, Label b);
    }
}
