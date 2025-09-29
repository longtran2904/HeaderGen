#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.SceneManagement
{
    public struct StageHandle : IEquatable<StageHandle>
    {
        public bool Contains(GameObject gameObject);
        public T FindComponentOfType<T>() where T : Component;
        public T[] FindComponentsOfType<T>() where T : Component;
        public bool IsValid();
        public override bool Equals(object other);
        public bool Equals(StageHandle other);
        public override int GetHashCode();

        public static bool operator ==(StageHandle s1, StageHandle s2);
        public static bool operator !=(StageHandle s1, StageHandle s2);
    }
}
