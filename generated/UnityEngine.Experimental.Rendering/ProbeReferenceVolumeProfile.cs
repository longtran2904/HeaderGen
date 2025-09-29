#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Experimental.Rendering
{
    public sealed class ProbeReferenceVolumeProfile : ScriptableObject
    {
        [Range(2, 5)]
        public int simplificationLevels;
        [Min(0.1F)]
        public float minDistanceBetweenProbes;

        public ProbeReferenceVolumeProfile();

        public int cellSizeInBricks { get; }
        public int maxSubdivision { get; }
        public float minBrickSize { get; }
        public float cellSizeInMeters { get; }

        public bool IsEquivalent(ProbeReferenceVolumeProfile otherProfile);
    }
}
