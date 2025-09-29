#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using UnityEditor;
using UnityEngine;

namespace TMPro.EditorUtilities
{
    [CustomPropertyDrawer(typeof(TMP_GlyphPairAdjustmentRecord))]
    public class TMP_GlyphPairAdjustmentRecordPropertyDrawer : PropertyDrawer
    {
        public TMP_GlyphPairAdjustmentRecordPropertyDrawer();

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label);
    }
}
