#region System.IO.Pipes, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.IO.Pipes.dll
#endregion

namespace System.IO.Pipes
{
    public static class NamedPipeServerStreamAcl
    {

        public static NamedPipeServerStream Create(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity, HandleInheritability inheritability = HandleInheritability.None, PipeAccessRights additionalAccessRights = 0);
    }
}
