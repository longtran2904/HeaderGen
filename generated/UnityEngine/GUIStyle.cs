#region UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
    [NativeHeader("IMGUIScriptingClasses.h")]
    [RequiredByNativeCode]
    public sealed class GUIStyle
    {

        public GUIStyle();
        public GUIStyle(GUIStyle other);

        ~GUIStyle();

        [NativeProperty("Font", False, TargetType.Function)]
        public Font font { get; set; }
        [NativeProperty("m_ImagePosition", False, TargetType.Field)]
        public ImagePosition imagePosition { get; set; }
        [NativeProperty("m_Alignment", False, TargetType.Field)]
        public TextAnchor alignment { get; set; }
        [NativeProperty("m_WordWrap", False, TargetType.Field)]
        public bool wordWrap { get; set; }
        [NativeProperty("m_Clipping", False, TargetType.Field)]
        public TextClipping clipping { get; set; }
        [NativeProperty("m_ContentOffset", False, TargetType.Field)]
        public Vector2 contentOffset { get; set; }
        [NativeProperty("m_FixedWidth", False, TargetType.Field)]
        public float fixedWidth { get; set; }
        [NativeProperty("m_FixedHeight", False, TargetType.Field)]
        public float fixedHeight { get; set; }
        [NativeProperty("m_StretchWidth", False, TargetType.Field)]
        public bool stretchWidth { get; set; }
        [NativeProperty("m_StretchHeight", False, TargetType.Field)]
        public bool stretchHeight { get; set; }
        [NativeProperty("m_FontSize", False, TargetType.Field)]
        public int fontSize { get; set; }
        [NativeProperty("m_FontStyle", False, TargetType.Field)]
        public FontStyle fontStyle { get; set; }
        [NativeProperty("m_RichText", False, TargetType.Field)]
        public bool richText { get; set; }
        [NativeProperty("m_ClipOffset", False, TargetType.Field)]
        [Obsolete("Don't use clipOffset - put things inside BeginGroup instead. This functionality will be removed in a later version.", False)]
        public Vector2 clipOffset { get; set; }
        public string name { get; set; }
        public GUIStyleState normal { get; set; }
        public GUIStyleState hover { get; set; }
        public GUIStyleState active { get; set; }
        public GUIStyleState onNormal { get; set; }
        public GUIStyleState onHover { get; set; }
        public GUIStyleState onActive { get; set; }
        public GUIStyleState focused { get; set; }
        public GUIStyleState onFocused { get; set; }
        public RectOffset border { get; set; }
        public RectOffset margin { get; set; }
        public RectOffset padding { get; set; }
        public RectOffset overflow { get; set; }
        public float lineHeight { get; }
        public static GUIStyle none { get; }
        public bool isHeightDependantOnWidth { get; }

        public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        public void Draw(Rect position, string text, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        public void Draw(Rect position, Texture image, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        public void Draw(Rect position, GUIContent content, int controlID);
        public void Draw(Rect position, GUIContent content, int controlID, bool on);
        public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover);
        public void DrawCursor(Rect position, GUIContent content, int controlID, int character);
        public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter);
        public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex);
        public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition);
        public Vector2 CalcSize(GUIContent content);
        public Vector2 CalcScreenSize(Vector2 contentSize);
        public float CalcHeight(GUIContent content, float width);
        public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth);
        public override string ToString();

        public static implicit operator GUIStyle(string str);
    }
}
