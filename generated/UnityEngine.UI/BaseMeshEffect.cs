#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [ExecuteAlways]
    public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier
    {

        protected BaseMeshEffect();

        protected Graphic graphic { get; }

        protected override void OnEnable();
        protected override void OnDisable();
        protected override void OnDidApplyAnimationProperties();
        protected override void OnValidate();
        public virtual void ModifyMesh(Mesh mesh);
        public abstract void ModifyMesh(VertexHelper vh);
    }
}
