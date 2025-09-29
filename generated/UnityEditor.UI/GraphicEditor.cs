#region UnityEditor.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.UI.dll
#endregion

using UnityEditor.AnimatedValues;
using UnityEngine.UI;

namespace UnityEditor.UI
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(MaskableGraphic), False)]
    public class GraphicEditor : Editor
    {

        protected SerializedProperty m_Script;
        protected SerializedProperty m_Color;
        protected SerializedProperty m_Material;
        protected SerializedProperty m_RaycastTarget;
        protected SerializedProperty m_RaycastPadding;
        protected SerializedProperty m_Maskable;
        protected AnimBool m_ShowNativeSize;

        public GraphicEditor();

        protected virtual void OnDisable();
        protected virtual void OnEnable();
        public override void OnInspectorGUI();
        protected void SetShowNativeSize(bool show, bool instant);
        protected void NativeSizeButtonGUI();
        protected void MaskableControlsGUI();
        protected void AppearanceControlsGUI();
        protected void RaycastControlsGUI();
    }
}
