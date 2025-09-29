#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor.Rendering
{
    public static class CoreEditorUtils
    {

        public static GraphicsDeviceType[] buildTargets { get; }

        public static string FindProperty<T, TValue>(Expression<Func<T, TValue>> expr);
        public static Texture2D CreateColoredTexture2D(Color color, string textureName);
        public static void DrawFixMeBox(string text, Action action);
        public static void DrawFixMeBox(GUIContent message, string buttonLabel, Action action);
        public static void DrawFixMeBox(GUIContent message, Action action);
        public static void DrawFixMeBox(string text, MessageType messageType, Action action);
        public static void DrawMultipleFields(string label, SerializedProperty[] ppts, GUIContent[] labels);
        public static void DrawEnumPopup<TEnum>(Rect rect, GUIContent label, SerializedProperty serializedProperty) where TEnum : Enum;
        public static void DrawMultipleFields(GUIContent label, SerializedProperty[] ppts, GUIContent[] labels);
        public static void DrawMultipleFields<T>(GUIContent label, GUIContent[] labels, T[] values) where T : struct;
        public static void DrawSplitter(bool isBoxed = False);
        public static void DrawHeader(string title);
        public static void DrawHeader(GUIContent title);
        public static bool DrawHeaderFoldout(string title, bool state, bool isBoxed = False, Func<bool> hasMoreOptions = null, Action toggleMoreOption = null);
        public static bool DrawHeaderFoldout(GUIContent title, bool state, bool isBoxed = False, Func<bool> hasMoreOptions = null, Action toggleMoreOptions = null, string documentationURL = "", Action<Vector2> contextAction = null);
        [Obsolete("'More Options' versions of DrawSubHeaderFoldout are obsolete. Please use DrawSubHeaderFoldout without 'More Options'")]
        public static bool DrawSubHeaderFoldout(string title, bool state, bool isBoxed = False, Func<bool> hasMoreOptions = null, Action toggleMoreOptions = null);
        [Obsolete("'More Options' versions of DrawSubHeaderFoldout are obsolete. Please use DrawSubHeaderFoldout without 'More Options'")]
        public static bool DrawSubHeaderFoldout(GUIContent title, bool state, bool isBoxed = False, Func<bool> hasMoreOptions = null, Action toggleMoreOptions = null);
        public static bool DrawSubHeaderFoldout(string title, bool state, bool isBoxed = False);
        public static bool DrawSubHeaderFoldout(GUIContent title, bool state, bool isBoxed = False);
        public static bool DrawHeaderToggle(string title, SerializedProperty group, SerializedProperty activeField, Action<Vector2> contextAction = null, Func<bool> hasMoreOptions = null, Action toggleMoreOptions = null);
        public static bool DrawHeaderToggle(GUIContent title, SerializedProperty group, SerializedProperty activeField, Action<Vector2> contextAction = null, Func<bool> hasMoreOptions = null, Action toggleMoreOptions = null);
        public static bool DrawHeaderToggle(string title, SerializedProperty group, SerializedProperty activeField, Action<Vector2> contextAction, Func<bool> hasMoreOptions, Action toggleMoreOptions, string documentationURL);
        public static bool DrawHeaderToggle(GUIContent title, SerializedProperty group, SerializedProperty activeField, Action<Vector2> contextAction, Func<bool> hasMoreOptions, Action toggleMoreOptions, string documentationURL);
        public static void DrawSectionHeader(GUIContent title, string documentationURL = null, Action<Vector2> contextAction = null, Func<bool> hasMoreOptions = null, Action toggleMoreOptions = null);
        public static void DrawVector6(GUIContent label, SerializedProperty positive, SerializedProperty negative, Vector3 min, Vector3 max, Color[] colors = null, SerializedProperty multiplicator = null, bool allowIntersection = True);
        public static void DrawPopup(GUIContent label, SerializedProperty property, string[] options);
        public static void DrawEnumPopup(SerializedProperty property, Type type, GUIContent label = null);
        public static void RemoveMaterialKeywords(Material material);
        public static T[] GetAdditionalData<T>(UnityEngine.Object[] targets, Action<T> initDefault = null) where T : Component;
        public static void AddAdditionalData<T, AdditionalT>(GameObject go, Action<AdditionalT> initDefault = null) where T : Component where AdditionalT : Component;
        public static GameObject CreateGameObject(GameObject parent, string name, params Type[] types);
        public static GameObject CreateGameObject(string name, UnityEngine.Object context);
        public static string GetCurrentProjectVersion();
        public static void CheckOutFile(bool VCSEnabled, UnityEngine.Object mat);
        public static Texture2D LoadIcon(string path, string name, string extention = ".png");
    }
}
