#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.ShaderGraph.Internal
{
    [BlackboardInputInfo(10, null)]
    [FormerName("UnityEditor.ShaderGraph.ColorShaderProperty")]
    public sealed class ColorShaderProperty : AbstractShaderProperty<Color>
    {

        public const int deprecatedVersion = 2;

        public override int latestVersion { get; }
        public override PropertyType propertyType { get; }
        public ColorMode colorMode { get; set; }

        public override string GetOldDefaultReferenceName();
        public override void OnAfterDeserialize(string json);
    }
}
