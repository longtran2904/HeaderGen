#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

namespace System.Net.Http.Headers
{
    public class RangeConditionHeaderValue : ICloneable
    {
        public RangeConditionHeaderValue(DateTimeOffset date);
        public RangeConditionHeaderValue(EntityTagHeaderValue entityTag);
        public RangeConditionHeaderValue(string entityTag);

        public DateTimeOffset? Date { get; }
        public EntityTagHeaderValue EntityTag { get; }

        public override string ToString();
        public override bool Equals(object obj);
        public override int GetHashCode();
        public static RangeConditionHeaderValue Parse(string input);
        public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue);
    }
}
