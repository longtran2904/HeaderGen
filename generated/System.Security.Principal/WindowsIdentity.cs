#region System.Security.Principal.Windows, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.Principal.Windows.dll
#endregion

using Microsoft.Win32.SafeHandles;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Threading.Tasks;

namespace System.Security.Principal
{
    public class WindowsIdentity : ClaimsIdentity, IDeserializationCallback, IDisposable, ISerializable
    {

        public const string DefaultIssuer = "AD AUTHORITY";

        public WindowsIdentity(nint userToken);
        public WindowsIdentity(nint userToken, string type);
        public WindowsIdentity(nint userToken, string type, WindowsAccountType acctType);
        public WindowsIdentity(nint userToken, string type, WindowsAccountType acctType, bool isAuthenticated);
        protected WindowsIdentity(WindowsIdentity identity);
        public WindowsIdentity(string sUserPrincipalName);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public WindowsIdentity(SerializationInfo info, StreamingContext context);

        public sealed override string AuthenticationType { get; }
        public TokenImpersonationLevel ImpersonationLevel { get; }
        public override bool IsAuthenticated { get; }
        public virtual bool IsGuest { get; }
        public virtual bool IsSystem { get; }
        public virtual bool IsAnonymous { get; }
        public override string Name { get; }
        public SecurityIdentifier Owner { get; }
        public SecurityIdentifier User { get; }
        public IdentityReferenceCollection Groups { get; }
        public SafeAccessTokenHandle AccessToken { get; }
        public virtual nint Token { get; }
        public virtual IEnumerable<Claim> UserClaims { get; }
        public virtual IEnumerable<Claim> DeviceClaims { get; }
        public override IEnumerable<Claim> Claims { get; }

        public static WindowsIdentity GetCurrent();
        public static WindowsIdentity GetCurrent(bool ifImpersonating);
        public static WindowsIdentity GetCurrent(TokenAccessLevels desiredAccess);
        public static WindowsIdentity GetAnonymous();
        public static void RunImpersonated(SafeAccessTokenHandle safeAccessTokenHandle, Action action);
        public static T RunImpersonated<T>(SafeAccessTokenHandle safeAccessTokenHandle, Func<T> func);
        public static Task RunImpersonatedAsync(SafeAccessTokenHandle safeAccessTokenHandle, Func<Task> func);
        public static Task<T> RunImpersonatedAsync<T>(SafeAccessTokenHandle safeAccessTokenHandle, Func<Task<T>> func);
        protected virtual void Dispose(bool disposing);
        public void Dispose();
        public override ClaimsIdentity Clone();
    }
}
