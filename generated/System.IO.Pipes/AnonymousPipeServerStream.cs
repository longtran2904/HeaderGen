#region System.IO.Pipes, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.IO.Pipes.dll
#endregion

using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes
{
    public sealed class AnonymousPipeServerStream : PipeStream
    {
        public AnonymousPipeServerStream();
        public AnonymousPipeServerStream(PipeDirection direction);
        public AnonymousPipeServerStream(PipeDirection direction, HandleInheritability inheritability);
        public AnonymousPipeServerStream(PipeDirection direction, SafePipeHandle serverSafePipeHandle, SafePipeHandle clientSafePipeHandle);
        public AnonymousPipeServerStream(PipeDirection direction, HandleInheritability inheritability, int bufferSize);

        ~AnonymousPipeServerStream();

        public SafePipeHandle ClientSafePipeHandle { get; }
        public override PipeTransmissionMode TransmissionMode { get; }
        public override PipeTransmissionMode ReadMode { set; }

        public string GetClientHandleAsString();
        public void DisposeLocalCopyOfClientHandle();
        protected override void Dispose(bool disposing);
    }
}
