#region UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
    [NativeHeader("Modules/IMGUI/GUI.bindings.h")]
    public class GUI
    {
        public GUI();

        public static Color color { get; set; }
        public static Color backgroundColor { get; set; }
        public static Color contentColor { get; set; }
        public static bool changed { get; set; }
        public static bool enabled { get; set; }
        public static int depth { get; set; }
        public static GUISkin skin { get; set; }
        public static Matrix4x4 matrix { get; set; }
        public static string tooltip { get; set; }
        protected static string mouseTooltip { get; }
        protected static Rect tooltipRect { get; set; }

        [FreeFunction("GetGUIState().SetNameOfNextControl")]
        public static void SetNextControlName(string name);
        [FreeFunction("GetGUIState().GetNameOfFocusedControl")]
        public static string GetNameOfFocusedControl();
        [FreeFunction("GetGUIState().FocusKeyboardControl")]
        public static void FocusControl(string name);
        public static void DragWindow(Rect position);
        public static void BringWindowToFront(int windowID);
        public static void BringWindowToBack(int windowID);
        public static void FocusWindow(int windowID);
        public static void UnfocusWindow();
        public static void Label(Rect position, string text);
        public static void Label(Rect position, Texture image);
        public static void Label(Rect position, GUIContent content);
        public static void Label(Rect position, string text, GUIStyle style);
        public static void Label(Rect position, Texture image, GUIStyle style);
        public static void Label(Rect position, GUIContent content, GUIStyle style);
        public static void DrawTexture(Rect position, Texture image);
        public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode);
        public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend);
        public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect);
        public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius);
        public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius);
        public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses);
        public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords);
        public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords, bool alphaBlend);
        public static void Box(Rect position, string text);
        public static void Box(Rect position, Texture image);
        public static void Box(Rect position, GUIContent content);
        public static void Box(Rect position, string text, GUIStyle style);
        public static void Box(Rect position, Texture image, GUIStyle style);
        public static void Box(Rect position, GUIContent content, GUIStyle style);
        public static bool Button(Rect position, string text);
        public static bool Button(Rect position, Texture image);
        public static bool Button(Rect position, GUIContent content);
        public static bool Button(Rect position, string text, GUIStyle style);
        public static bool Button(Rect position, Texture image, GUIStyle style);
        public static bool Button(Rect position, GUIContent content, GUIStyle style);
        public static bool RepeatButton(Rect position, string text);
        public static bool RepeatButton(Rect position, Texture image);
        public static bool RepeatButton(Rect position, GUIContent content);
        public static bool RepeatButton(Rect position, string text, GUIStyle style);
        public static bool RepeatButton(Rect position, Texture image, GUIStyle style);
        public static bool RepeatButton(Rect position, GUIContent content, GUIStyle style);
        public static string TextField(Rect position, string text);
        public static string TextField(Rect position, string text, int maxLength);
        public static string TextField(Rect position, string text, GUIStyle style);
        public static string TextField(Rect position, string text, int maxLength, GUIStyle style);
        public static string PasswordField(Rect position, string password, char maskChar);
        public static string PasswordField(Rect position, string password, char maskChar, int maxLength);
        public static string PasswordField(Rect position, string password, char maskChar, GUIStyle style);
        public static string PasswordField(Rect position, string password, char maskChar, int maxLength, GUIStyle style);
        public static string TextArea(Rect position, string text);
        public static string TextArea(Rect position, string text, int maxLength);
        public static string TextArea(Rect position, string text, GUIStyle style);
        public static string TextArea(Rect position, string text, int maxLength, GUIStyle style);
        public static bool Toggle(Rect position, bool value, string text);
        public static bool Toggle(Rect position, bool value, Texture image);
        public static bool Toggle(Rect position, bool value, GUIContent content);
        public static bool Toggle(Rect position, bool value, string text, GUIStyle style);
        public static bool Toggle(Rect position, bool value, Texture image, GUIStyle style);
        public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style);
        public static bool Toggle(Rect position, int id, bool value, GUIContent content, GUIStyle style);
        public static int Toolbar(Rect position, int selected, string[] texts);
        public static int Toolbar(Rect position, int selected, Texture[] images);
        public static int Toolbar(Rect position, int selected, GUIContent[] contents);
        public static int Toolbar(Rect position, int selected, string[] texts, GUIStyle style);
        public static int Toolbar(Rect position, int selected, Texture[] images, GUIStyle style);
        public static int Toolbar(Rect position, int selected, GUIContent[] contents, GUIStyle style);
        public static int Toolbar(Rect position, int selected, GUIContent[] contents, GUIStyle style, ToolbarButtonSize buttonSize);
        public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount);
        public static int SelectionGrid(Rect position, int selected, Texture[] images, int xCount);
        public static int SelectionGrid(Rect position, int selected, GUIContent[] content, int xCount);
        public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount, GUIStyle style);
        public static int SelectionGrid(Rect position, int selected, Texture[] images, int xCount, GUIStyle style);
        public static int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style);
        public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue);
        public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb);
        public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle thumbExtent);
        public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue);
        public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue, GUIStyle slider, GUIStyle thumb);
        public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue, GUIStyle slider, GUIStyle thumb, GUIStyle thumbExtent);
        public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null);
        public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue);
        public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style);
        public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue);
        public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style);
        public static void BeginClip(Rect position, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset);
        public static void BeginGroup(Rect position);
        public static void BeginGroup(Rect position, string text);
        public static void BeginGroup(Rect position, Texture image);
        public static void BeginGroup(Rect position, GUIContent content);
        public static void BeginGroup(Rect position, GUIStyle style);
        public static void BeginGroup(Rect position, string text, GUIStyle style);
        public static void BeginGroup(Rect position, Texture image, GUIStyle style);
        public static void BeginGroup(Rect position, GUIContent content, GUIStyle style);
        public static void EndGroup();
        public static void BeginClip(Rect position);
        public static void EndClip();
        public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect);
        public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical);
        public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar);
        public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar);
        protected static Vector2 DoBeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background);
        public static void EndScrollView();
        public static void EndScrollView(bool handleScrollWheel);
        public static void ScrollTo(Rect position);
        public static bool ScrollTowards(Rect position, float maxDelta);
        public static Rect Window(int id, Rect clientRect, WindowFunction func, string text);
        public static Rect Window(int id, Rect clientRect, WindowFunction func, Texture image);
        public static Rect Window(int id, Rect clientRect, WindowFunction func, GUIContent content);
        public static Rect Window(int id, Rect clientRect, WindowFunction func, string text, GUIStyle style);
        public static Rect Window(int id, Rect clientRect, WindowFunction func, Texture image, GUIStyle style);
        public static Rect Window(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style);
        public static Rect ModalWindow(int id, Rect clientRect, WindowFunction func, string text);
        public static Rect ModalWindow(int id, Rect clientRect, WindowFunction func, Texture image);
        public static Rect ModalWindow(int id, Rect clientRect, WindowFunction func, GUIContent content);
        public static Rect ModalWindow(int id, Rect clientRect, WindowFunction func, string text, GUIStyle style);
        public static Rect ModalWindow(int id, Rect clientRect, WindowFunction func, Texture image, GUIStyle style);
        public static Rect ModalWindow(int id, Rect clientRect, WindowFunction func, GUIContent content, GUIStyle style);
        public static void DragWindow();

        public enum ToolbarButtonSize
        {
            Fixed = 0,
            FitToContents = 1
        }
        public delegate void WindowFunction(int id);
        public abstract class Scope : IDisposable
        {
            protected Scope();

            ~Scope();

            public void Dispose();
            protected abstract void CloseScope();
        }
        public class GroupScope : Scope
        {
            public GroupScope(Rect position);
            public GroupScope(Rect position, string text);
            public GroupScope(Rect position, Texture image);
            public GroupScope(Rect position, GUIContent content);
            public GroupScope(Rect position, GUIStyle style);
            public GroupScope(Rect position, string text, GUIStyle style);
            public GroupScope(Rect position, Texture image, GUIStyle style);

            protected override void CloseScope();
        }
        public class ScrollViewScope : Scope
        {
            public ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect);
            public ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical);
            public ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar);
            public ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar);

            public Vector2 scrollPosition { get; }
            public bool handleScrollWheel { get; set; }

            protected override void CloseScope();
        }
        public class ClipScope : Scope
        {
            public ClipScope(Rect position);

            protected override void CloseScope();
        }
    }
}
