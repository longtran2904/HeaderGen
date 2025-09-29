#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Security
{
    [Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
    public class PermissionSet : ICollection, IDeserializationCallback, IEnumerable, ISecurityEncodable, IStackWalk
    {
        public PermissionSet(PermissionState state);
        public PermissionSet(PermissionSet permSet);

        public virtual int Count { get; }
        public virtual bool IsReadOnly { get; }
        public virtual bool IsSynchronized { get; }
        public virtual object SyncRoot { get; }

        public IPermission AddPermission(IPermission perm);
        protected virtual IPermission AddPermissionImpl(IPermission perm);
        public void Assert();
        public bool ContainsNonCodeAccessPermissions();
        [Obsolete]
        public static byte[] ConvertPermissionSet(string inFormat, byte[] inData, string outFormat);
        public virtual PermissionSet Copy();
        public virtual void CopyTo(Array array, int index);
        public void Demand();
        [Obsolete]
        public void Deny();
        public override bool Equals(object o);
        public virtual void FromXml(SecurityElement et);
        public IEnumerator GetEnumerator();
        protected virtual IEnumerator GetEnumeratorImpl();
        public override int GetHashCode();
        public IPermission GetPermission(Type permClass);
        protected virtual IPermission GetPermissionImpl(Type permClass);
        public PermissionSet Intersect(PermissionSet other);
        public bool IsEmpty();
        public bool IsSubsetOf(PermissionSet target);
        public bool IsUnrestricted();
        public void PermitOnly();
        public IPermission RemovePermission(Type permClass);
        protected virtual IPermission RemovePermissionImpl(Type permClass);
        public static void RevertAssert();
        public IPermission SetPermission(IPermission perm);
        protected virtual IPermission SetPermissionImpl(IPermission perm);
        public override string ToString();
        public virtual SecurityElement ToXml();
        public PermissionSet Union(PermissionSet other);
    }
}
