#region UnityEditor.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.UI.dll
#endregion

using UnityEngine.EventSystems;

namespace UnityEditor.EventSystems
{
    [CustomEditor(typeof(Physics2DRaycaster), True)]
    public class Physics2DRaycasterEditor : Editor
    {

        public Physics2DRaycasterEditor();

        public override void OnInspectorGUI();
    }
}
