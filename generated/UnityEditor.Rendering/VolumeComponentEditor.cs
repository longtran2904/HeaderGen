#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor.Rendering
{
    public class VolumeComponentEditor
    {
        protected Editor m_Inspector;

        public VolumeComponentEditor();

        public VolumeComponent target { get; }
        public SerializedObject serializedObject { get; }
        public SerializedProperty baseProperty { get; }
        public SerializedProperty activeProperty { get; }
        public virtual bool hasAdditionalProperties { get; }
        public bool showAdditionalProperties { get; set; }

        protected bool BeginAdditionalPropertiesScope();
        protected void EndAdditionalPropertiesScope();
        public void Repaint();
        public virtual void OnEnable();
        public virtual void OnDisable();
        public virtual void OnInspectorGUI();
        public virtual GUIContent GetDisplayTitle();
        protected SerializedDataParameter Unpack(SerializedProperty property);
        protected bool PropertyField(SerializedDataParameter property);
        protected void DrawHeader(string header);
        protected bool PropertyField(SerializedDataParameter property, GUIContent title);
        protected void DrawOverrideCheckbox(SerializedDataParameter property);

        protected struct OverridablePropertyScope : IDisposable
        {
            public OverridablePropertyScope(SerializedDataParameter property, GUIContent label, VolumeComponentEditor editor);
            public OverridablePropertyScope(SerializedDataParameter property, string label, VolumeComponentEditor editor);

            public bool displayed { get; }
            public GUIContent label { get; }
        }
        protected class IndentLevelScope : GUI.Scope
        {
            public IndentLevelScope(int offset = 15);

            protected override void CloseScope();
        }
    }
}
