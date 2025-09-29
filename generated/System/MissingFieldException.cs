#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System
{
    public class MissingFieldException : MissingMemberException
    {
        public MissingFieldException();
        public MissingFieldException(string message);
        public MissingFieldException(string message, Exception inner);
        public MissingFieldException(string className, string fieldName);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected MissingFieldException(SerializationInfo info, StreamingContext context);

        public override string Message { get; }
    }
}
