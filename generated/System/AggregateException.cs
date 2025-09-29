#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace System
{
    public class AggregateException : Exception
    {
        public AggregateException();
        public AggregateException(string message);
        public AggregateException(string message, Exception innerException);
        public AggregateException(IEnumerable<Exception> innerExceptions);
        public AggregateException(params Exception[] innerExceptions);
        public AggregateException(string message, IEnumerable<Exception> innerExceptions);
        public AggregateException(string message, params Exception[] innerExceptions);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected AggregateException(SerializationInfo info, StreamingContext context);

        public ReadOnlyCollection<Exception> InnerExceptions { get; }
        public override string Message { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override Exception GetBaseException();
        public void Handle(Func<Exception, bool> predicate);
        public AggregateException Flatten();
        public override string ToString();
    }
}
