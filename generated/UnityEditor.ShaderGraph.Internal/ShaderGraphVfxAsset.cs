#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.ShaderGraph.Internal
{
    public sealed class ShaderGraphVfxAsset : ScriptableObject, ISerializationCallbackReceiver
    {

        [SerializeField]
        public bool generatesWithShaderGraph;
        [SerializeField]
        public bool lit;
        [SerializeField]
        public bool alphaClipping;
        public const int BaseColorSlotId = 1;
        public const int MetallicSlotId = 2;
        public const int SmoothnessSlotId = 3;
        public const int NormalSlotId = 8;
        public const int AlphaSlotId = 4;
        public const int EmissiveSlotId = 5;
        public const int ColorSlotId = 6;
        public const int AlphaThresholdSlotId = 7;

        public ShaderGraphVfxAsset();

        public IEnumerable<TextureInfo> textureInfos { get; }
        public string evaluationFunctionName { get; }
        public string inputStructName { get; }
        public string outputStructName { get; }
        public List<AbstractShaderProperty> properties { get; }
        public List<AbstractShaderProperty> fragmentProperties { get; }
        public List<AbstractShaderProperty> vertexProperties { get; }

        public OutputMetadata GetOutput(int id);
        public bool HasOutput(int id);
        public GraphCode GetCode(OutputMetadata[] outputs);
    }
}
