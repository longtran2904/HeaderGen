#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using Unity.Collections;
using UnityEngine.SceneManagement;

namespace UnityEditor
{
    public struct UpdatePrefabInstancesEventArgs
    {

        public UpdatePrefabInstancesEventArgs(Scene scene, NativeArray<int>.ReadOnly instanceIds);

        public Scene scene { get; }
        public NativeArray<int>.ReadOnly instanceIds { get; }
    }
}
