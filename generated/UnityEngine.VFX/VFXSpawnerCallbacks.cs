#region UnityEngine.VFXModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VFXModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
    [RequiredByNativeCode]
    public abstract class VFXSpawnerCallbacks : ScriptableObject
    {

        protected VFXSpawnerCallbacks();

        public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);
        public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);
        public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);
    }
}
