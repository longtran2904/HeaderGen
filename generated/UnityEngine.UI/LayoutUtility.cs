#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;

namespace UnityEngine.UI
{
    public static class LayoutUtility
    {

        public static float GetMinSize(RectTransform rect, int axis);
        public static float GetPreferredSize(RectTransform rect, int axis);
        public static float GetFlexibleSize(RectTransform rect, int axis);
        public static float GetMinWidth(RectTransform rect);
        public static float GetPreferredWidth(RectTransform rect);
        public static float GetFlexibleWidth(RectTransform rect);
        public static float GetMinHeight(RectTransform rect);
        public static float GetPreferredHeight(RectTransform rect);
        public static float GetFlexibleHeight(RectTransform rect);
        public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue);
        public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source);
    }
}
