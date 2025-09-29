#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices
{
    public struct GCHandle : IEquatable<GCHandle>
    {

        public object Target { get; set; }
        public bool IsAllocated { get; }

        public static GCHandle Alloc(object value);
        public static GCHandle Alloc(object value, GCHandleType type);
        public void Free();
        public nint AddrOfPinnedObject();
        public static GCHandle FromIntPtr(nint value);
        public static nint ToIntPtr(GCHandle value);
        public override int GetHashCode();
        public override bool Equals(object o);
        public bool Equals(GCHandle other);

        public static bool operator ==(GCHandle a, GCHandle b);
        public static bool operator !=(GCHandle a, GCHandle b);

        public static explicit operator GCHandle(nint value);
        public static explicit operator nint(GCHandle value);
    }
}
