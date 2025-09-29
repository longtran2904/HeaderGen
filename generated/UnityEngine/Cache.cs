#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Misc/Cache.h")]
    [StaticAccessor("CacheWrapper", StaticAccessorType.DoubleColon)]
    public struct Cache : IEquatable<Cache>
    {
        public bool valid { get; }
        public bool ready { get; }
        public bool readOnly { get; }
        public string path { get; }
        public int index { get; }
        public long spaceFree { get; }
        public long maximumAvailableStorageSpace { get; set; }
        public long spaceOccupied { get; }
        public int expirationDelay { get; set; }

        public override int GetHashCode();
        public override bool Equals(object other);
        public bool Equals(Cache other);
        public bool ClearCache();
        public bool ClearCache(int expiration);

        public static bool operator ==(Cache lhs, Cache rhs);
        public static bool operator !=(Cache lhs, Cache rhs);
    }
}
