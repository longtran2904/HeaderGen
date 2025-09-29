#region System.IO.Pipes, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.IO.Pipes.dll
#endregion

using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes
{
    public sealed class AnonymousPipeClientStream : PipeStream
    {
        public AnonymousPipeClientStream(string pipeHandleAsString);
        public AnonymousPipeClientStream(PipeDirection direction, string pipeHandleAsString);
        public AnonymousPipeClientStream(PipeDirection direction, SafePipeHandle safePipeHandle);

        ~AnonymousPipeClientStream();

        public override PipeTransmissionMode TransmissionMode { get; }
        public override PipeTransmissionMode ReadMode { set; }
    }
}
