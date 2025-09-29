#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/EditorResources.h")]
    [NativeHeader("Runtime/Graphics/Texture2D.h")]
    [NativeHeader("Runtime/Graphics/RenderTexture.h")]
    [NativeHeader("Editor/Src/Utility/EditorGUIUtility.h")]
    [NativeHeader("Modules/TextRendering/Public/Font.h")]
    public sealed class EditorGUIUtility : GUIUtility
    {
        [Obsolete("This field is no longer used by any builtin controls. If passing this field to GetControlID, explicitly use the FocusType enum instead.", False)]
        public static FocusType native;

        public EditorGUIUtility();

        public static Texture2D whiteTexture { get; }
        public static string systemCopyBuffer { get; set; }
        public static float pixelsPerPoint { get; }
        public static float singleLineHeight { get; }
        public static float standardVerticalSpacing { get; }
        public static bool isProSkin { get; }
        public static bool editingTextField { get; set; }
        public static bool textFieldHasSelection { get; }
        public static bool hierarchyMode { get; set; }
        public static bool wideMode { get; set; }
        public static float currentViewWidth { get; }
        public static float labelWidth { get; set; }
        public static float fieldWidth { get; set; }

        public static string SerializeMainMenuToString();
        public static void SetMenuLocalizationTestMode(bool onoff);
        public static void SetIconSize(Vector2 size);
        public static void SetWantsMouseJumping(int wantz);
        public static bool IsDisplayReferencedByCameras(int displayIndex);
        public static void QueueGameViewInputEvent(Event evt);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("RenderGameViewCameras is no longer supported.Consider rendering cameras manually.", True)]
        public static void RenderGameViewCameras(RenderTexture target, int targetDisplay, Rect screenRect, Vector2 mousePosition, bool gizmos);
        public static void SetIconForObject([NotNull("ArgumentNullException")] UnityEngine.Object obj, Texture2D icon);
        public static Texture2D GetIconForObject([NotNull("ArgumentNullException")] UnityEngine.Object obj);
        public static Rect GetMainWindowPosition();
        public static void SetMainWindowPosition(Rect position);
        public static Rect PointsToPixels(Rect rect);
        public static Rect PixelsToPoints(Rect rect);
        public static Vector2 PointsToPixels(Vector2 position);
        public static Vector2 PixelsToPoints(Vector2 position);
        public static List<Rect> GetFlowLayoutedRects(Rect rect, GUIStyle style, float horizontalSpacing, float verticalSpacing, List<string> items);
        public static Texture2D FindTexture(string name);
        public static GUIContent TrTextContent(string key, string text, string tooltip, Texture icon);
        public static GUIContent TrTextContent(string text, string tooltip = null, Texture icon = null);
        public static GUIContent TrTextContent(string text, string tooltip, string iconName);
        public static GUIContent TrTextContent(string text, Texture icon);
        public static GUIContent TrTextContentWithIcon(string text, Texture icon);
        public static GUIContent TrTextContentWithIcon(string text, string iconName);
        public static GUIContent TrTextContentWithIcon(string text, string tooltip, string iconName);
        public static GUIContent TrTextContentWithIcon(string text, string tooltip, Texture icon);
        public static GUIContent TrTextContentWithIcon(string text, string tooltip, MessageType messageType);
        public static GUIContent TrTextContentWithIcon(string text, MessageType messageType);
        public static GUIContent TrIconContent(string iconName, string tooltip = null);
        public static GUIContent TrIconContent(Texture icon, string tooltip = null);
        [ExcludeFromDocs]
        public static GUIContent TrTempContent(string t);
        [ExcludeFromDocs]
        public static GUIContent[] TrTempContent(string[] texts);
        [ExcludeFromDocs]
        public static GUIContent[] TrTempContent(string[] texts, string[] tooltips);
        [ExcludeFromDocs]
        public static GUIContent IconContent(string name);
        public static GUIContent IconContent(string name, [DefaultValue("null")] string text);
        public static GUIContent ObjectContent(UnityEngine.Object obj, Type type);
        public static bool HasObjectThumbnail(Type objType);
        public static Vector2 GetIconSize();
        public static GUISkin GetBuiltinSkin(EditorSkin skin);
        public static UnityEngine.Object LoadRequired(string path);
        public static UnityEngine.Object Load(string path);
        public static void PingObject(UnityEngine.Object obj);
        public static void PingObject(int targetInstanceID);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("RenderGameViewCameras is no longer supported.Consider rendering cameras manually.", True)]
        public static void RenderGameViewCameras(Rect cameraRect, bool gizmos, bool gui);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("RenderGameViewCameras is no longer supported.Consider rendering cameras manually.", True)]
        public static void RenderGameViewCameras(Rect cameraRect, Rect statsRect, bool gizmos, bool gui);
        [Obsolete("LookLikeControls and LookLikeInspector modes are deprecated.Use EditorGUIUtility.labelWidth and EditorGUIUtility.fieldWidth to control label and field widths.", False)]
        public static void LookLikeControls(float _labelWidth, float _fieldWidth);
        [ExcludeFromDocs]
        [Obsolete("LookLikeControls and LookLikeInspector modes are deprecated.Use EditorGUIUtility.labelWidth and EditorGUIUtility.fieldWidth to control label and field widths.", False)]
        public static void LookLikeControls(float _labelWidth);
        [ExcludeFromDocs]
        [Obsolete("LookLikeControls and LookLikeInspector modes are deprecated.Use EditorGUIUtility.labelWidth and EditorGUIUtility.fieldWidth to control label and field widths.", False)]
        public static void LookLikeControls();
        [Obsolete("LookLikeControls and LookLikeInspector modes are deprecated.", False)]
        public static void LookLikeInspector();
        public static Event CommandEvent(string commandName);
        public static void DrawColorSwatch(Rect position, Color color);
        public static void DrawCurveSwatch(Rect position, AnimationCurve curve, SerializedProperty property, Color color, Color bgColor);
        public static void DrawCurveSwatch(Rect position, AnimationCurve curve, SerializedProperty property, Color color, Color bgColor, Color topFillColor, Color bottomFillColor);
        public static void DrawCurveSwatch(Rect position, AnimationCurve curve, SerializedProperty property, Color color, Color bgColor, Color topFillColor, Color bottomFillColor, Rect curveRanges);
        public static void DrawCurveSwatch(Rect position, AnimationCurve curve, SerializedProperty property, Color color, Color bgColor, Rect curveRanges);
        public static void DrawRegionSwatch(Rect position, SerializedProperty property, SerializedProperty property2, Color color, Color bgColor, Rect curveRanges);
        public static void DrawRegionSwatch(Rect position, AnimationCurve curve, AnimationCurve curve2, Color color, Color bgColor, Rect curveRanges);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("EditorGUIUtility.RGBToHSV is obsolete. Use Color.RGBToHSV instead (UnityUpgradable) -> [UnityEngine] UnityEngine.Color.RGBToHSV(*)", True)]
        public static void RGBToHSV(Color rgbColor, out float H, out float S, out float V);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("EditorGUIUtility.HSVToRGB is obsolete. Use Color.HSVToRGB instead (UnityUpgradable) -> [UnityEngine] UnityEngine.Color.HSVToRGB(*)", True)]
        public static Color HSVToRGB(float H, float S, float V);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("EditorGUIUtility.HSVToRGB is obsolete. Use Color.HSVToRGB instead (UnityUpgradable) -> [UnityEngine] UnityEngine.Color.HSVToRGB(*)", True)]
        public static Color HSVToRGB(float H, float S, float V, bool hdr);
        public static void AddCursorRect(Rect position, MouseCursor mouse);
        public static void AddCursorRect(Rect position, MouseCursor mouse, int controlID);
        public static void ShowObjectPicker<T>(UnityEngine.Object obj, bool allowSceneObjects, string searchFilter, int controlID) where T : UnityEngine.Object;
        public static UnityEngine.Object GetObjectPickerObject();
        public static int GetObjectPickerControlID();

        public class PropertyCallbackScope : IDisposable
        {
            public PropertyCallbackScope(Action<Rect, SerializedProperty> callback);

            public void Dispose();
        }
        public class IconSizeScope : GUI.Scope
        {
            public IconSizeScope(Vector2 iconSizeWithinScope);

            protected override void CloseScope();
        }
    }
}
