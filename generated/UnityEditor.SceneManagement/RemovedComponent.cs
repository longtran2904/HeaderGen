#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.SceneManagement
{
    public class RemovedComponent : PrefabOverride
    {
        public RemovedComponent();

        public GameObject containingInstanceGameObject { get; set; }
        public Component assetComponent { get; set; }

        public override void Apply(string prefabAssetPath, InteractionMode mode);
        public override void Revert(InteractionMode mode);
        public override UnityEngine.Object GetAssetObject();
    }
}
