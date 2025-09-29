#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.SceneManagement
{
    public abstract class PrefabOverride
    {
        protected PrefabOverride();

        public abstract void Apply(string prefabAssetPath, InteractionMode mode);
        public abstract void Revert(InteractionMode mode);
        public void Apply();
        public void Apply(string prefabAssetPath);
        public void Apply(InteractionMode mode);
        public void Revert();
        protected UnityEngine.Object FindApplyTargetAssetObject(string prefabAssetPath);
        public abstract UnityEngine.Object GetAssetObject();
    }
}
