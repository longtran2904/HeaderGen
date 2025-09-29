#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    public enum PrefabInstanceStatus
    {
        NotAPrefab = 0,
        Connected = 1,
        [Obsolete("PrefabInstanceStatus.Disconnected has been deprecated and is not used. Prefabs can not be in a disconnected state.")]
        Disconnected = 2,
        MissingAsset = 3
    }
}
