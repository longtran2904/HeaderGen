#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.Rendering
{
    [AddComponentMenu("Miscellaneous/Volume")]
    [CoreRPHelpURL("Volumes", "com.unity.render-pipelines.high-definition")]
    [ExecuteAlways]
    public class Volume : MonoBehaviour, IVolume
    {

        [Tooltip("When multiple Volumes affect the same settings, Unity uses this value to determine which Volume to use. A Volume with the highest Priority value takes precedence.")]
        public float priority;
        [Tooltip("Sets the outer distance to start blending from. A value of 0 means no blending and Unity applies the Volume overrides immediately upon entry.")]
        public float blendDistance;
        [Range(0, 1)]
        [Tooltip("Sets the total weight of this Volume in the Scene. 0 means no effect and 1 means full effect.")]
        public float weight;
        public VolumeProfile sharedProfile;

        public Volume();

        [Tooltip("When enabled, the Volume is applied to the entire Scene.")]
        public bool isGlobal { get; set; }
        public VolumeProfile profile { get; set; }
        public List<Collider> colliders { get; }

        public bool HasInstantiatedProfile();
    }
}
