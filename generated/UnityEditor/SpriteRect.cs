#region Unity.2D.Sprite.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Sprite.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public class SpriteRect
    {

        public SpriteRect();

        public string name { get; set; }
        public Vector2 pivot { get; set; }
        public SpriteAlignment alignment { get; set; }
        public Vector4 border { get; set; }
        public Rect rect { get; set; }
        public GUID spriteID { get; set; }

        public static GUID GetSpriteIDFromSerializedProperty(SerializedProperty sp);
    }
}
