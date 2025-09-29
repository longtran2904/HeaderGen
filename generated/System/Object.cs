#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public class Object
    {

        public Object();

        protected virtual void Finalize();

        public Type GetType();
        protected object MemberwiseClone();
        public virtual string ToString();
        public virtual bool Equals(object obj);
        public static bool Equals(object objA, object objB);
        public static bool ReferenceEquals(object objA, object objB);
        public virtual int GetHashCode();
    }
}
