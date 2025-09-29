#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.Collections.Generic;

namespace System.Net.Http.Headers
{
    public class ContentDispositionHeaderValue : ICloneable
    {

        protected ContentDispositionHeaderValue(ContentDispositionHeaderValue source);
        public ContentDispositionHeaderValue(string dispositionType);

        public string DispositionType { get; set; }
        public ICollection<NameValueHeaderValue> Parameters { get; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public string FileNameStar { get; set; }
        public DateTimeOffset? CreationDate { get; set; }
        public DateTimeOffset? ModificationDate { get; set; }
        public DateTimeOffset? ReadDate { get; set; }
        public long? Size { get; set; }

        public override string ToString();
        public override bool Equals(object obj);
        public override int GetHashCode();
        public static ContentDispositionHeaderValue Parse(string input);
        public static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue);
    }
}
