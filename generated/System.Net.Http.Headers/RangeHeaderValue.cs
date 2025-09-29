#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.Collections.Generic;

namespace System.Net.Http.Headers
{
    public class RangeHeaderValue : ICloneable
    {

        public RangeHeaderValue();
        public RangeHeaderValue(long? from, long? to);

        public string Unit { get; set; }
        public ICollection<RangeItemHeaderValue> Ranges { get; }

        public override string ToString();
        public override bool Equals(object obj);
        public override int GetHashCode();
        public static RangeHeaderValue Parse(string input);
        public static bool TryParse(string input, out RangeHeaderValue parsedValue);
    }
}
