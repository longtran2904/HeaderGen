#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.Rendering.BuiltIn.ShaderGraph
{
    public class BuiltInBaseShaderGUI : ShaderGUI
    {
        public bool m_FirstTimeApply;

        public BuiltInBaseShaderGUI();

        public override void OnGUI(MaterialEditor materialEditor, MaterialProperty[] properties);
        public virtual void OnOpenGUI(Material material, MaterialEditor materialEditor, MaterialProperty[] properties);
        public override void AssignNewShaderToMaterial(Material material, Shader oldShader, Shader newShader);
        protected virtual void DrawSurfaceOptions(Material material);
        protected virtual void DrawSurfaceInputs(Material material);
        protected virtual void DrawAdvancedOptions(Material material);
        protected void DrawQueueOffsetField(MaterialEditor materialEditor, Material material, MaterialProperty[] properties);
        public override void ValidateMaterial(Material material);
        public static void SetupSurface(Material material);
        public static void DoPopup(GUIContent label, MaterialEditor materialEditor, MaterialProperty property, string[] options);
        public static void DoIntPopup(GUIContent label, MaterialEditor materialEditor, MaterialProperty property, string[] options, int[] optionValues);
        public static void DrawFloatToggleProperty(GUIContent styles, MaterialProperty prop);

        [Flags]
        protected enum Expandable
        {
            SurfaceOptions = 1,
            SurfaceInputs = 2,
            Advanced = 4
        }
        public enum SurfaceType
        {
            Opaque = 0,
            Transparent = 1
        }
        public enum BlendMode
        {
            Alpha = 0,
            Premultiply = 1,
            Additive = 2,
            Multiply = 3
        }
        public enum RenderFace
        {
            Front = 2,
            Back = 1,
            Both = 0
        }
        public enum QueueControl
        {
            Auto = 0,
            UserOverride = 1
        }
        protected class Styles
        {
            public static readonly string[] surfaceTypeNames;
            public static readonly string[] blendModeNames;
            public static readonly string[] renderFaceNames;
            public static readonly string[] zwriteNames;
            public static readonly int[] ztestValues;
            public static readonly string[] ztestNames;
            public static readonly string[] queueControlNames;
            public static readonly GUIContent SurfaceOptions;
            public static readonly GUIContent SurfaceInputs;
            public static readonly GUIContent AdvancedLabel;
            public static readonly GUIContent surfaceType;
            public static readonly GUIContent blendingMode;
            public static readonly GUIContent cullingText;
            public static readonly GUIContent zwriteText;
            public static readonly GUIContent ztestText;
            public static readonly GUIContent alphaClipText;
            public static readonly GUIContent queueSlider;
            public static readonly GUIContent queueControl;

            public Styles();
        }
    }
}
