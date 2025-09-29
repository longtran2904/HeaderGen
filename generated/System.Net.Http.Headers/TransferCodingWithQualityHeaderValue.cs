#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

namespace System.Net.Http.Headers
{
    public sealed class TransferCodingWithQualityHeaderValue : TransferCodingHeaderValue
    {

        public TransferCodingWithQualityHeaderValue(string value);
        public TransferCodingWithQualityHeaderValue(string value, double quality);

        public double? Quality { get; set; }

        public static TransferCodingWithQualityHeaderValue Parse(string input);
        public static bool TryParse(string input, out TransferCodingWithQualityHeaderValue parsedValue);
    }
}
