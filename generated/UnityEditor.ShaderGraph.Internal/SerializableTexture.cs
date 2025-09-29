#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.ShaderGraph.Internal
{
    public sealed class SerializableTexture : ISerializationCallbackReceiver
    {
        public SerializableTexture();

        public Texture texture { get; set; }

        public void OnBeforeSerialize();
        public void OnAfterDeserialize();
    }
}
