#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.ShaderGraph.Drawing.Colors
{
    public class CustomColorData : ISerializationCallbackReceiver
    {
        public CustomColorData();

        public bool TryGetColor(string provider, out Color color);
        public void Set(string provider, Color color);
        public void Remove(string provider);
        public void OnBeforeSerialize();
        public void OnAfterDeserialize();
    }
}
