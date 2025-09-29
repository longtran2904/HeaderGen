#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    [Obsolete("PrefabType no longer tells everything about Prefab instance.")]
    public enum PrefabType
    {

        None = 0,
        Prefab = 1,
        ModelPrefab = 2,
        PrefabInstance = 3,
        ModelPrefabInstance = 4,
        MissingPrefabInstance = 5,
        [Obsolete("PrefabType.DisconnectedPrefabInstance has been deprecated and is not used. Prefabs can not be in a disconnected state.")]
        DisconnectedPrefabInstance = 6,
        [Obsolete("PrefabType.DisconnectedModelPrefabInstance has been deprecated and is not used. Prefabs can not be in a disconnected state.")]
        DisconnectedModelPrefabInstance = 7
    }
}
