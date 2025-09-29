#region UnityEditor.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.UI.dll
#endregion

using UnityEngine.UI;

namespace UnityEditor.UI
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(RectMask2D), True)]
    public class RectMask2DEditor : Editor
    {
        public RectMask2DEditor();

        protected virtual void OnEnable();
        public override void OnInspectorGUI();
    }
}
