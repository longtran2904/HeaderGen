#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Collections
{
    public sealed class Comparer : IComparer, ISerializable
    {

        public static readonly Comparer Default;
        public static readonly Comparer DefaultInvariant;

        public Comparer(CultureInfo culture);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public void GetObjectData(SerializationInfo info, StreamingContext context);
        public int Compare(object a, object b);
    }
}
