#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement
{
    [NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
    public struct Scene
    {
        public int handle { get; }
        public string path { get; }
        public string name { get; set; }
        public bool isLoaded { get; }
        public int buildIndex { get; }
        public bool isDirty { get; }
        public int rootCount { get; }
        public bool isSubScene { get; set; }

        public bool IsValid();
        public GameObject[] GetRootGameObjects();
        public void GetRootGameObjects(List<GameObject> rootGameObjects);
        public override int GetHashCode();
        public override bool Equals(object other);

        public static bool operator ==(Scene lhs, Scene rhs);
        public static bool operator !=(Scene lhs, Scene rhs);
    }
}
