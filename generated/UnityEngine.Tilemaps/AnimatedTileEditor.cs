#region Unity.2D.Tilemap.Extras, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.dll
#endregion

using UnityEditor;

namespace UnityEngine.Tilemaps
{
    [CustomEditor(typeof(AnimatedTile))]
    public class AnimatedTileEditor : Editor
    {

        public AnimatedTileEditor();

        public override void OnInspectorGUI();
    }
}
