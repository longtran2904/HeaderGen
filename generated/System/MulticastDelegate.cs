#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;

namespace System
{
    public abstract class MulticastDelegate : Delegate
    {

        protected MulticastDelegate(object target, string method);
        protected MulticastDelegate(Type target, string method);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public sealed override bool Equals(object obj);
        protected sealed override Delegate CombineImpl(Delegate follow);
        protected sealed override Delegate RemoveImpl(Delegate value);
        public sealed override Delegate[] GetInvocationList();
        public sealed override int GetHashCode();
        protected override MethodInfo GetMethodImpl();

        public static bool operator ==(MulticastDelegate d1, MulticastDelegate d2);
        public static bool operator !=(MulticastDelegate d1, MulticastDelegate d2);
    }
}
