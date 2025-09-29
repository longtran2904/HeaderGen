#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

namespace UnityEditor.ShaderGraph.Internal
{
    [BlackboardInputInfo(52, null)]
    [FormerName("UnityEditor.ShaderGraph.Texture3DShaderProperty")]
    public sealed class Texture3DShaderProperty : AbstractShaderProperty<SerializableTexture>
    {

        public override PropertyType propertyType { get; }
        public bool modifiable { get; set; }
    }
}
