#region UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TerrainModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [ExcludeFromPreset]
    [NativeHeader("Modules/Terrain/Public/Tree.h")]
    public sealed class Tree : Component
    {

        public Tree();

        [NativeProperty("TreeData")]
        public ScriptableObject data { get; set; }
        public bool hasSpeedTreeWind { get; }
    }
}
