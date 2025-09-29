#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [NativeHeader("Runtime/Utilities/GUID.h")]
    [RequiredByNativeCode]
    public struct GUID : IComparable, IComparable<GUID>, IEquatable<GUID>
    {
        public GUID(string hexRepresentation);

        public override bool Equals(object obj);
        public bool Equals(GUID obj);
        public override int GetHashCode();
        public int CompareTo(object obj);
        public int CompareTo(GUID rhs);
        public bool Empty();
        [Obsolete("Use TryParse instead")]
        public bool ParseExact(string hex);
        public static bool TryParse(string hex, out GUID result);
        public static GUID Generate();
        public override string ToString();

        public static bool operator ==(GUID x, GUID y);
        public static bool operator !=(GUID x, GUID y);
        public static bool operator <(GUID x, GUID y);
        public static bool operator >(GUID x, GUID y);
    }
}
