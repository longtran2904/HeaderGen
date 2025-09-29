#region Unity.RenderPipelines.Universal.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Editor.dll
#endregion

using UnityEngine.Rendering.Universal;

namespace UnityEditor.Rendering.Universal
{
    [CustomEditor(typeof(ScriptableRendererData), True)]
    public class ScriptableRendererDataEditor : Editor
    {

        public ScriptableRendererDataEditor();

        public override void OnInspectorGUI();
    }
}
