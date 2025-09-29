#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Security.Permissions
{
    [Flags]
    [Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
    public enum SecurityPermissionFlag
    {

        AllFlags = 16383,
        Assertion = 1,
        BindingRedirects = 8192,
        ControlAppDomain = 1024,
        ControlDomainPolicy = 256,
        ControlEvidence = 32,
        ControlPolicy = 64,
        ControlPrincipal = 512,
        ControlThread = 16,
        Execution = 8,
        Infrastructure = 4096,
        NoFlags = 0,
        RemotingConfiguration = 2048,
        SerializationFormatter = 128,
        SkipVerification = 4,
        UnmanagedCode = 2
    }
}
