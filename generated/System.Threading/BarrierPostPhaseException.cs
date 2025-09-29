#region System.Threading, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Threading.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Threading
{
    public class BarrierPostPhaseException : Exception
    {

        public BarrierPostPhaseException();
        public BarrierPostPhaseException(Exception innerException);
        public BarrierPostPhaseException(string message);
        public BarrierPostPhaseException(string message, Exception innerException);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected BarrierPostPhaseException(SerializationInfo info, StreamingContext context);
    }
}
