#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Experimental.Rendering
{
    [AddComponentMenu("Light/Probe Volume (Experimental)")]
    [ExecuteAlways]
    public class ProbeVolume : MonoBehaviour
    {

        public bool globalVolume;
        public Vector3 size;
        [HideInInspector]
        [Range(0, 2)]
        public float geometryDistanceOffset;
        public LayerMask objectLayerMask;
        [HideInInspector]
        public int lowestSubdivLevelOverride;
        [HideInInspector]
        public int highestSubdivLevelOverride;
        [HideInInspector]
        public bool overridesSubdivLevels;

        public ProbeVolume();

        public Vector3 GetExtents();
        public override int GetHashCode();
    }
}
