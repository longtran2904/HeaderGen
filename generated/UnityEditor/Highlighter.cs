#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/Highlighter/HighlighterCore.bindings.h")]
    public sealed class Highlighter
    {
        public Highlighter();

        public static string activeText { get; }
        [NativeProperty("s_ActiveRect", False, TargetType.Field)]
        public static Rect activeRect { get; }
        [NativeProperty("s_ActiveVisible", False, TargetType.Field)]
        public static bool activeVisible { get; }
        public static bool active { get; }

        public static void Stop();
        public static bool Highlight(string windowTitle, string text);
        public static bool Highlight(string windowTitle, string text, HighlightSearchMode mode);
        public static void HighlightIdentifier(Rect position, string identifier);
    }
}
