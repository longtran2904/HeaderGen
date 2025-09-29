#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Text
{
    public sealed class EncoderFallbackException : ArgumentException
    {
        public EncoderFallbackException();
        public EncoderFallbackException(string message);
        public EncoderFallbackException(string message, Exception innerException);

        public char CharUnknown { get; }
        public char CharUnknownHigh { get; }
        public char CharUnknownLow { get; }
        public int Index { get; }

        public bool IsUnknownSurrogate();
    }
}
