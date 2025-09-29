#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine
{
    [UsedByNativeCode]
    public class TrackedReference
    {
        protected TrackedReference();

        public override bool Equals(object o);
        public override int GetHashCode();

        public static bool operator ==(TrackedReference x, TrackedReference y);
        public static bool operator !=(TrackedReference x, TrackedReference y);

        public static implicit operator bool(TrackedReference exists);
    }
}
