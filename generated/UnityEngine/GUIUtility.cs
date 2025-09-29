#region UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/IMGUI/GUIManager.h")]
    [NativeHeader("Modules/IMGUI/GUIUtility.h")]
    [NativeHeader("Runtime/Input/InputBindings.h")]
    [NativeHeader("Runtime/Camera/RenderLayers/GUITexture.h")]
    [NativeHeader("Runtime/Utilities/CopyPaste.h")]
    [NativeHeader("Runtime/Input/InputManager.h")]
    public class GUIUtility
    {
        public GUIUtility();

        public static bool hasModalWindow { get; }
        public static string systemCopyBuffer { get; set; }
        public static int hotControl { get; set; }
        public static int keyboardControl { get; set; }

        public static int GetControlID(int hint, FocusType focusType, Rect rect);
        public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels);
        public static int GetControlID(FocusType focus);
        public static int GetControlID(GUIContent contents, FocusType focus);
        public static int GetControlID(FocusType focus, Rect position);
        public static int GetControlID(GUIContent contents, FocusType focus, Rect position);
        public static int GetControlID(int hint, FocusType focus);
        public static object GetStateObject(Type t, int controlID);
        public static object QueryStateObject(Type t, int controlID);
        public static void ExitGUI();
        public static Vector2 GUIToScreenPoint(Vector2 guiPoint);
        public static Rect GUIToScreenRect(Rect guiRect);
        public static Vector2 ScreenToGUIPoint(Vector2 screenPoint);
        public static Rect ScreenToGUIRect(Rect screenRect);
        public static void RotateAroundPivot(float angle, Vector2 pivotPoint);
        public static void ScaleAroundPivot(Vector2 scale, Vector2 pivotPoint);
        public static Rect AlignRectToDevice(Rect rect);
    }
}
