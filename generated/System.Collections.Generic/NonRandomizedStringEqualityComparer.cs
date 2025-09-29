#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
    public class NonRandomizedStringEqualityComparer : IEqualityComparer<string>, IInternalStringEqualityComparer, ISerializable
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected NonRandomizedStringEqualityComparer(SerializationInfo information, StreamingContext context);

        public virtual bool Equals(string x, string y);
        public virtual int GetHashCode(string obj);
        public virtual IEqualityComparer<string> GetUnderlyingEqualityComparer();
        public static IEqualityComparer<string> GetStringComparer(object comparer);
    }
}
