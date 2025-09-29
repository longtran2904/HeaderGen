#region UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEditor.Graphs.dll
#endregion

using UnityEngine;

namespace UnityEditor.Graphs
{
    public class Styles
    {
        public static GUIStyle graphBackground;
        public static GUIContent connectionTexture;
        public static GUIContent selectedConnectionTexture;
        public static GUIStyle varPinIn;
        public static GUIStyle varPinOut;
        public static GUIStyle varPinTooltip;
        public static GUIStyle targetPinIn;
        public static GUIStyle triggerPinIn;
        public static GUIStyle triggerPinOut;
        public static GUIStyle selectionRect;
        public static GUIStyle nodeGroupButton;
        public static GUIStyle nodeTitlebar;
        public static GUIStyle nodeAddButton;

        public Styles();

        public static GUIStyle GetNodeStyle(string styleName, Color color, bool on);

        public enum Color
        {
            Grey = 0,
            Gray = 0,
            Blue = 1,
            Aqua = 2,
            Green = 3,
            Yellow = 4,
            Orange = 5,
            Red = 6
        }
    }
}
