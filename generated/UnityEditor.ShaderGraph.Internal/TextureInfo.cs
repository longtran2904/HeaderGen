#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor.ShaderGraph.Internal
{
    public struct TextureInfo
    {
        public string name;
        public Texture texture;
        public TextureDimension dimension;

        public TextureInfo(string name, Texture texture, TextureDimension dimension);

        public int instanceID { get; }
    }
}
