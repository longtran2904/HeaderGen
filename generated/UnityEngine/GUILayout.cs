#region UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

namespace UnityEngine
{
    public class GUILayout
    {
        public GUILayout();

        public static void Label(Texture image, params GUILayoutOption[] options);
        public static void Label(string text, params GUILayoutOption[] options);
        public static void Label(GUIContent content, params GUILayoutOption[] options);
        public static void Label(Texture image, GUIStyle style, params GUILayoutOption[] options);
        public static void Label(string text, GUIStyle style, params GUILayoutOption[] options);
        public static void Label(GUIContent content, GUIStyle style, params GUILayoutOption[] options);
        public static void Box(Texture image, params GUILayoutOption[] options);
        public static void Box(string text, params GUILayoutOption[] options);
        public static void Box(GUIContent content, params GUILayoutOption[] options);
        public static void Box(Texture image, GUIStyle style, params GUILayoutOption[] options);
        public static void Box(string text, GUIStyle style, params GUILayoutOption[] options);
        public static void Box(GUIContent content, GUIStyle style, params GUILayoutOption[] options);
        public static bool Button(Texture image, params GUILayoutOption[] options);
        public static bool Button(string text, params GUILayoutOption[] options);
        public static bool Button(GUIContent content, params GUILayoutOption[] options);
        public static bool Button(Texture image, GUIStyle style, params GUILayoutOption[] options);
        public static bool Button(string text, GUIStyle style, params GUILayoutOption[] options);
        public static bool Button(GUIContent content, GUIStyle style, params GUILayoutOption[] options);
        public static bool RepeatButton(Texture image, params GUILayoutOption[] options);
        public static bool RepeatButton(string text, params GUILayoutOption[] options);
        public static bool RepeatButton(GUIContent content, params GUILayoutOption[] options);
        public static bool RepeatButton(Texture image, GUIStyle style, params GUILayoutOption[] options);
        public static bool RepeatButton(string text, GUIStyle style, params GUILayoutOption[] options);
        public static bool RepeatButton(GUIContent content, GUIStyle style, params GUILayoutOption[] options);
        public static string TextField(string text, params GUILayoutOption[] options);
        public static string TextField(string text, int maxLength, params GUILayoutOption[] options);
        public static string TextField(string text, GUIStyle style, params GUILayoutOption[] options);
        public static string TextField(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options);
        public static string PasswordField(string password, char maskChar, params GUILayoutOption[] options);
        public static string PasswordField(string password, char maskChar, int maxLength, params GUILayoutOption[] options);
        public static string PasswordField(string password, char maskChar, GUIStyle style, params GUILayoutOption[] options);
        public static string PasswordField(string password, char maskChar, int maxLength, GUIStyle style, params GUILayoutOption[] options);
        public static string TextArea(string text, params GUILayoutOption[] options);
        public static string TextArea(string text, int maxLength, params GUILayoutOption[] options);
        public static string TextArea(string text, GUIStyle style, params GUILayoutOption[] options);
        public static string TextArea(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options);
        public static bool Toggle(bool value, Texture image, params GUILayoutOption[] options);
        public static bool Toggle(bool value, string text, params GUILayoutOption[] options);
        public static bool Toggle(bool value, GUIContent content, params GUILayoutOption[] options);
        public static bool Toggle(bool value, Texture image, GUIStyle style, params GUILayoutOption[] options);
        public static bool Toggle(bool value, string text, GUIStyle style, params GUILayoutOption[] options);
        public static bool Toggle(bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options);
        public static int Toolbar(int selected, string[] texts, params GUILayoutOption[] options);
        public static int Toolbar(int selected, Texture[] images, params GUILayoutOption[] options);
        public static int Toolbar(int selected, GUIContent[] contents, params GUILayoutOption[] options);
        public static int Toolbar(int selected, string[] texts, GUIStyle style, params GUILayoutOption[] options);
        public static int Toolbar(int selected, Texture[] images, GUIStyle style, params GUILayoutOption[] options);
        public static int Toolbar(int selected, string[] texts, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options);
        public static int Toolbar(int selected, Texture[] images, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options);
        public static int Toolbar(int selected, GUIContent[] contents, GUIStyle style, params GUILayoutOption[] options);
        public static int Toolbar(int selected, GUIContent[] contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options);
        public static int Toolbar(int selected, GUIContent[] contents, bool[] enabled, GUIStyle style, params GUILayoutOption[] options);
        public static int Toolbar(int selected, GUIContent[] contents, bool[] enabled, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options);
        public static int SelectionGrid(int selected, string[] texts, int xCount, params GUILayoutOption[] options);
        public static int SelectionGrid(int selected, Texture[] images, int xCount, params GUILayoutOption[] options);
        public static int SelectionGrid(int selected, GUIContent[] content, int xCount, params GUILayoutOption[] options);
        public static int SelectionGrid(int selected, string[] texts, int xCount, GUIStyle style, params GUILayoutOption[] options);
        public static int SelectionGrid(int selected, Texture[] images, int xCount, GUIStyle style, params GUILayoutOption[] options);
        public static int SelectionGrid(int selected, GUIContent[] contents, int xCount, GUIStyle style, params GUILayoutOption[] options);
        public static float HorizontalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options);
        public static float HorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options);
        public static float VerticalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options);
        public static float VerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options);
        public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, params GUILayoutOption[] options);
        public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUIStyle style, params GUILayoutOption[] options);
        public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, params GUILayoutOption[] options);
        public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, GUIStyle style, params GUILayoutOption[] options);
        public static void Space(float pixels);
        public static void FlexibleSpace();
        public static void BeginHorizontal(params GUILayoutOption[] options);
        public static void BeginHorizontal(GUIStyle style, params GUILayoutOption[] options);
        public static void BeginHorizontal(string text, GUIStyle style, params GUILayoutOption[] options);
        public static void BeginHorizontal(Texture image, GUIStyle style, params GUILayoutOption[] options);
        public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options);
        public static void EndHorizontal();
        public static void BeginVertical(params GUILayoutOption[] options);
        public static void BeginVertical(GUIStyle style, params GUILayoutOption[] options);
        public static void BeginVertical(string text, GUIStyle style, params GUILayoutOption[] options);
        public static void BeginVertical(Texture image, GUIStyle style, params GUILayoutOption[] options);
        public static void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options);
        public static void EndVertical();
        public static void BeginArea(Rect screenRect);
        public static void BeginArea(Rect screenRect, string text);
        public static void BeginArea(Rect screenRect, Texture image);
        public static void BeginArea(Rect screenRect, GUIContent content);
        public static void BeginArea(Rect screenRect, GUIStyle style);
        public static void BeginArea(Rect screenRect, string text, GUIStyle style);
        public static void BeginArea(Rect screenRect, Texture image, GUIStyle style);
        public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style);
        public static void EndArea();
        public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options);
        public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options);
        public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options);
        public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style);
        public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options);
        public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options);
        public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options);
        public static void EndScrollView();
        public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[] options);
        public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, params GUILayoutOption[] options);
        public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, params GUILayoutOption[] options);
        public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, GUIStyle style, params GUILayoutOption[] options);
        public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, GUIStyle style, params GUILayoutOption[] options);
        public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, params GUILayoutOption[] options);
        public static GUILayoutOption Width(float width);
        public static GUILayoutOption MinWidth(float minWidth);
        public static GUILayoutOption MaxWidth(float maxWidth);
        public static GUILayoutOption Height(float height);
        public static GUILayoutOption MinHeight(float minHeight);
        public static GUILayoutOption MaxHeight(float maxHeight);
        public static GUILayoutOption ExpandWidth(bool expand);
        public static GUILayoutOption ExpandHeight(bool expand);

        public class HorizontalScope : GUI.Scope
        {
            public HorizontalScope(params GUILayoutOption[] options);
            public HorizontalScope(GUIStyle style, params GUILayoutOption[] options);
            public HorizontalScope(string text, GUIStyle style, params GUILayoutOption[] options);
            public HorizontalScope(Texture image, GUIStyle style, params GUILayoutOption[] options);
            public HorizontalScope(GUIContent content, GUIStyle style, params GUILayoutOption[] options);

            protected override void CloseScope();
        }
        public class VerticalScope : GUI.Scope
        {
            public VerticalScope(params GUILayoutOption[] options);
            public VerticalScope(GUIStyle style, params GUILayoutOption[] options);
            public VerticalScope(string text, GUIStyle style, params GUILayoutOption[] options);
            public VerticalScope(Texture image, GUIStyle style, params GUILayoutOption[] options);
            public VerticalScope(GUIContent content, GUIStyle style, params GUILayoutOption[] options);

            protected override void CloseScope();
        }
        public class AreaScope : GUI.Scope
        {
            public AreaScope(Rect screenRect);
            public AreaScope(Rect screenRect, string text);
            public AreaScope(Rect screenRect, Texture image);
            public AreaScope(Rect screenRect, GUIContent content);
            public AreaScope(Rect screenRect, string text, GUIStyle style);
            public AreaScope(Rect screenRect, Texture image, GUIStyle style);
            public AreaScope(Rect screenRect, GUIContent content, GUIStyle style);

            protected override void CloseScope();
        }
        public class ScrollViewScope : GUI.Scope
        {
            public ScrollViewScope(Vector2 scrollPosition, params GUILayoutOption[] options);
            public ScrollViewScope(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options);
            public ScrollViewScope(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options);
            public ScrollViewScope(Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options);
            public ScrollViewScope(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options);
            public ScrollViewScope(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options);

            public Vector2 scrollPosition { get; }
            public bool handleScrollWheel { get; set; }

            protected override void CloseScope();
        }
    }
}
