#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEditor.EditorTools;
using UnityEngine;

namespace UnityEditor
{
    [EditorTool("Light Anchor", typeof(LightAnchor))]
    public class LightAnchorEditorTool : EditorTool
    {

        public LightAnchorEditorTool();

        public override GUIContent toolbarIcon { get; }

        public override bool IsAvailable();
        public override void OnToolGUI(EditorWindow window);
    }
}
