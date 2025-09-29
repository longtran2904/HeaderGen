#region UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/IMGUI/GUILayoutUtility.bindings.h")]
    public class GUILayoutUtility
    {

        public GUILayoutUtility();

        [Obsolete("BeginGroup has no effect and will be removed", False)]
        public static void BeginGroup(string GroupName);
        [Obsolete("EndGroup has no effect and will be removed", False)]
        public static void EndGroup(string groupName);
        public static Rect GetRect(GUIContent content, GUIStyle style);
        public static Rect GetRect(GUIContent content, GUIStyle style, params GUILayoutOption[] options);
        public static Rect GetRect(float width, float height);
        public static Rect GetRect(float width, float height, GUIStyle style);
        public static Rect GetRect(float width, float height, params GUILayoutOption[] options);
        public static Rect GetRect(float width, float height, GUIStyle style, params GUILayoutOption[] options);
        public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight);
        public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style);
        public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, params GUILayoutOption[] options);
        public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, params GUILayoutOption[] options);
        public static Rect GetLastRect();
        public static Rect GetAspectRect(float aspect);
        public static Rect GetAspectRect(float aspect, GUIStyle style);
        public static Rect GetAspectRect(float aspect, params GUILayoutOption[] options);
        public static Rect GetAspectRect(float aspect, GUIStyle style, params GUILayoutOption[] options);
    }
}
