#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

namespace System.Net.Http.Headers
{
    public class ViaHeaderValue : ICloneable
    {

        public ViaHeaderValue(string protocolVersion, string receivedBy);
        public ViaHeaderValue(string protocolVersion, string receivedBy, string protocolName);
        public ViaHeaderValue(string protocolVersion, string receivedBy, string protocolName, string comment);

        public string ProtocolName { get; }
        public string ProtocolVersion { get; }
        public string ReceivedBy { get; }
        public string Comment { get; }

        public override string ToString();
        public override bool Equals(object obj);
        public override int GetHashCode();
        public static ViaHeaderValue Parse(string input);
        public static bool TryParse(string input, out ViaHeaderValue parsedValue);
    }
}
