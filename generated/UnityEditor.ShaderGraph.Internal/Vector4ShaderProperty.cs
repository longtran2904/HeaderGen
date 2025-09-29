#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

namespace UnityEditor.ShaderGraph.Internal
{
    [BlackboardInputInfo(4, null)]
    [FormerName("UnityEditor.ShaderGraph.Vector4ShaderProperty")]
    public sealed class Vector4ShaderProperty : VectorShaderProperty
    {
        public override PropertyType propertyType { get; }
        public override int latestVersion { get; }

        public override void OnAfterDeserialize(string json);
    }
}
