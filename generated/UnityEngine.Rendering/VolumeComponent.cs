#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System.Collections.ObjectModel;

namespace UnityEngine.Rendering
{
    public class VolumeComponent : ScriptableObject
    {
        public bool active;

        public VolumeComponent();

        public string displayName { get; protected set; }
        public ReadOnlyCollection<VolumeParameter> parameters { get; }

        protected virtual void OnEnable();
        protected virtual void OnDisable();
        public virtual void Override(VolumeComponent state, float interpFactor);
        public void SetAllOverridesTo(bool state);
        public override int GetHashCode();
        protected virtual void OnDestroy();
        public void Release();

        public sealed class Indent : PropertyAttribute
        {
            public readonly int relativeAmount;

            public Indent(int relativeAmount = 1);
        }
    }
}
