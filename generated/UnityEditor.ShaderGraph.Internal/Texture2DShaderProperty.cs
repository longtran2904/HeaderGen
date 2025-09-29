#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

namespace UnityEditor.ShaderGraph.Internal
{
    [BlackboardInputInfo(50, null)]
    [FormerName("UnityEditor.ShaderGraph.TextureShaderProperty")]
    public sealed class Texture2DShaderProperty : AbstractShaderProperty<SerializableTexture>
    {
        public override PropertyType propertyType { get; }
        public DefaultType defaultType { get; set; }

        public enum DefaultType
        {
            White = 0,
            Black = 1,
            Grey = 2,
            NormalMap = 3,
            LinearGrey = 4,
            Red = 5
        }
    }
}
