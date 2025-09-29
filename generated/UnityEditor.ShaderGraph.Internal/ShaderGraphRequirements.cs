#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using System.Collections.Generic;

namespace UnityEditor.ShaderGraph.Internal
{
    public struct ShaderGraphRequirements
    {

        public List<NeededTransform> requiresTransforms { get; }
        public NeededCoordinateSpace requiresNormal { get; }
        public NeededCoordinateSpace requiresBitangent { get; }
        public NeededCoordinateSpace requiresTangent { get; }
        public NeededCoordinateSpace requiresViewDir { get; }
        public NeededCoordinateSpace requiresPosition { get; }
        public NeededCoordinateSpace requiresPositionPredisplacement { get; }
        public bool requiresScreenPosition { get; }
        public bool requiresVertexColor { get; }
        public bool requiresFaceSign { get; }
        public List<UVChannel> requiresMeshUVs { get; }
        public bool requiresDepthTexture { get; }
        public bool requiresCameraOpaqueTexture { get; }
        public bool requiresTime { get; }
        public bool requiresVertexSkinning { get; }
        public bool requiresVertexID { get; }
    }
}
