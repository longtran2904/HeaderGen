#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

namespace System.Net.Http.Headers
{
    public class EntityTagHeaderValue : ICloneable
    {
        public EntityTagHeaderValue(string tag);
        public EntityTagHeaderValue(string tag, bool isWeak);

        public string Tag { get; }
        public bool IsWeak { get; }
        public static EntityTagHeaderValue Any { get; }

        public override string ToString();
        public override bool Equals(object obj);
        public override int GetHashCode();
        public static EntityTagHeaderValue Parse(string input);
        public static bool TryParse(string input, out EntityTagHeaderValue parsedValue);
    }
}
