#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEditor
{
    public sealed class EditorGUI
    {
        public EditorGUI();

        public static bool showMixedValue { get; set; }
        public static bool actionKey { get; }
        public static int indentLevel { get; set; }

        public static event Action<EditorWindow, HyperLinkClickedEventArgs> hyperLinkClicked;

        public static void FocusTextInControl(string name);
        public static void BeginDisabledGroup(bool disabled);
        public static void EndDisabledGroup();
        public static void BeginChangeCheck();
        public static bool EndChangeCheck();
        public static void DropShadowLabel(Rect position, string text);
        public static void DropShadowLabel(Rect position, GUIContent content);
        public static void DropShadowLabel(Rect position, string text, GUIStyle style);
        public static void DropShadowLabel(Rect position, GUIContent content, GUIStyle style);
        public static bool Toggle(Rect position, bool value);
        public static bool Toggle(Rect position, string label, bool value);
        public static bool Toggle(Rect position, bool value, GUIStyle style);
        public static bool Toggle(Rect position, string label, bool value, GUIStyle style);
        public static bool Toggle(Rect position, GUIContent label, bool value);
        public static bool Toggle(Rect position, GUIContent label, bool value, GUIStyle style);
        [Obsolete("Use PasswordField instead.")]
        public static string DoPasswordField(int id, Rect position, string password, GUIStyle style);
        [Obsolete("Use PasswordField instead.")]
        public static string DoPasswordField(int id, Rect position, GUIContent label, string password, GUIStyle style);
        public static float Slider(Rect position, float value, float leftValue, float rightValue);
        public static float Slider(Rect position, string label, float value, float leftValue, float rightValue);
        public static float Slider(Rect position, GUIContent label, float value, float leftValue, float rightValue);
        public static void Slider(Rect position, SerializedProperty property, float leftValue, float rightValue);
        public static void Slider(Rect position, SerializedProperty property, float leftValue, float rightValue, string label);
        public static void Slider(Rect position, SerializedProperty property, float leftValue, float rightValue, GUIContent label);
        public static int IntSlider(Rect position, int value, int leftValue, int rightValue);
        public static int IntSlider(Rect position, string label, int value, int leftValue, int rightValue);
        public static int IntSlider(Rect position, GUIContent label, int value, int leftValue, int rightValue);
        public static void IntSlider(Rect position, SerializedProperty property, int leftValue, int rightValue);
        public static void IntSlider(Rect position, SerializedProperty property, int leftValue, int rightValue, string label);
        public static void IntSlider(Rect position, SerializedProperty property, int leftValue, int rightValue, GUIContent label);
        [Obsolete("Switch the order of the first two parameters.")]
        public static void MinMaxSlider(GUIContent label, Rect position, ref float minValue, ref float maxValue, float minLimit, float maxLimit);
        public static void MinMaxSlider(Rect position, string label, ref float minValue, ref float maxValue, float minLimit, float maxLimit);
        public static void MinMaxSlider(Rect position, GUIContent label, ref float minValue, ref float maxValue, float minLimit, float maxLimit);
        public static void MinMaxSlider(Rect position, ref float minValue, ref float maxValue, float minLimit, float maxLimit);
        public static Enum EnumFlagsField(Rect position, Enum enumValue);
        public static Enum EnumFlagsField(Rect position, Enum enumValue, GUIStyle style);
        public static Enum EnumFlagsField(Rect position, string label, Enum enumValue);
        public static Enum EnumFlagsField(Rect position, string label, Enum enumValue, GUIStyle style);
        public static Enum EnumFlagsField(Rect position, GUIContent label, Enum enumValue);
        public static Enum EnumFlagsField(Rect position, GUIContent label, Enum enumValue, GUIStyle style);
        public static Enum EnumFlagsField(Rect position, GUIContent label, Enum enumValue, [DefaultValue("false")] bool includeObsolete, [DefaultValue("null")] GUIStyle style = null);
        public static void ObjectField(Rect position, SerializedProperty property);
        public static void ObjectField(Rect position, SerializedProperty property, GUIContent label);
        public static void ObjectField(Rect position, SerializedProperty property, Type objType);
        public static void ObjectField(Rect position, SerializedProperty property, Type objType, GUIContent label);
        public static UnityEngine.Object ObjectField(Rect position, UnityEngine.Object obj, Type objType, UnityEngine.Object targetBeingEdited);
        public static UnityEngine.Object ObjectField(Rect position, UnityEngine.Object obj, Type objType, bool allowSceneObjects);
        [Obsolete("Check the docs for the usage of the new parameter 'allowSceneObjects'.")]
        public static UnityEngine.Object ObjectField(Rect position, UnityEngine.Object obj, Type objType);
        public static UnityEngine.Object ObjectField(Rect position, string label, UnityEngine.Object obj, Type objType, UnityEngine.Object targetBeingEdited);
        public static UnityEngine.Object ObjectField(Rect position, string label, UnityEngine.Object obj, Type objType, bool allowSceneObjects);
        [Obsolete("Check the docs for the usage of the new parameter 'allowSceneObjects'.")]
        public static UnityEngine.Object ObjectField(Rect position, string label, UnityEngine.Object obj, Type objType);
        public static UnityEngine.Object ObjectField(Rect position, GUIContent label, UnityEngine.Object obj, Type objType, UnityEngine.Object targetBeingEdited);
        public static UnityEngine.Object ObjectField(Rect position, GUIContent label, UnityEngine.Object obj, Type objType, bool allowSceneObjects);
        [Obsolete("Check the docs for the usage of the new parameter 'allowSceneObjects'.")]
        public static UnityEngine.Object ObjectField(Rect position, GUIContent label, UnityEngine.Object obj, Type objType);
        public static Rect IndentedRect(Rect source);
        public static Vector2 Vector2Field(Rect position, string label, Vector2 value);
        public static Vector2 Vector2Field(Rect position, GUIContent label, Vector2 value);
        public static Vector3 Vector3Field(Rect position, string label, Vector3 value);
        public static Vector3 Vector3Field(Rect position, GUIContent label, Vector3 value);
        public static Vector4 Vector4Field(Rect position, string label, Vector4 value);
        public static Vector4 Vector4Field(Rect position, GUIContent label, Vector4 value);
        public static Vector2Int Vector2IntField(Rect position, string label, Vector2Int value);
        public static Vector2Int Vector2IntField(Rect position, GUIContent label, Vector2Int value);
        public static Vector3Int Vector3IntField(Rect position, string label, Vector3Int value);
        public static Vector3Int Vector3IntField(Rect position, GUIContent label, Vector3Int value);
        public static Rect RectField(Rect position, Rect value);
        public static Rect RectField(Rect position, string label, Rect value);
        public static Rect RectField(Rect position, GUIContent label, Rect value);
        public static RectInt RectIntField(Rect position, RectInt value);
        public static RectInt RectIntField(Rect position, string label, RectInt value);
        public static RectInt RectIntField(Rect position, GUIContent label, RectInt value);
        public static Bounds BoundsField(Rect position, Bounds value);
        public static Bounds BoundsField(Rect position, string label, Bounds value);
        public static Bounds BoundsField(Rect position, GUIContent label, Bounds value);
        public static BoundsInt BoundsIntField(Rect position, BoundsInt value);
        public static BoundsInt BoundsIntField(Rect position, string label, BoundsInt value);
        public static BoundsInt BoundsIntField(Rect position, GUIContent label, BoundsInt value);
        public static void MultiFloatField(Rect position, GUIContent label, GUIContent[] subLabels, float[] values);
        public static void MultiFloatField(Rect position, GUIContent[] subLabels, float[] values);
        public static void MultiIntField(Rect position, GUIContent[] subLabels, int[] values);
        public static void MultiPropertyField(Rect position, GUIContent[] subLabels, SerializedProperty valuesIterator, GUIContent label);
        public static void MultiPropertyField(Rect position, GUIContent[] subLabels, SerializedProperty valuesIterator);
        public static Color ColorField(Rect position, Color value);
        public static Color ColorField(Rect position, string label, Color value);
        public static Color ColorField(Rect position, GUIContent label, Color value);
        [Obsolete("Use EditorGUI.ColorField(Rect position, GUIContent label, Color value, bool showEyedropper, bool showAlpha, bool hdr)")]
        public static Color ColorField(Rect position, GUIContent label, Color value, bool showEyedropper, bool showAlpha, bool hdr, ColorPickerHDRConfig hdrConfig);
        public static Color ColorField(Rect position, GUIContent label, Color value, bool showEyedropper, bool showAlpha, bool hdr);
        public static AnimationCurve CurveField(Rect position, AnimationCurve value);
        public static AnimationCurve CurveField(Rect position, string label, AnimationCurve value);
        public static AnimationCurve CurveField(Rect position, GUIContent label, AnimationCurve value);
        public static AnimationCurve CurveField(Rect position, AnimationCurve value, Color color, Rect ranges);
        public static AnimationCurve CurveField(Rect position, string label, AnimationCurve value, Color color, Rect ranges);
        public static AnimationCurve CurveField(Rect position, GUIContent label, AnimationCurve value, Color color, Rect ranges);
        public static void CurveField(Rect position, SerializedProperty property, Color color, Rect ranges);
        public static void CurveField(Rect position, SerializedProperty property, Color color, Rect ranges, GUIContent label);
        public static void InspectorTitlebar(Rect position, UnityEngine.Object[] targetObjs);
        public static bool InspectorTitlebar(Rect position, bool foldout, UnityEngine.Object targetObj, bool expandable);
        public static bool InspectorTitlebar(Rect position, bool foldout, UnityEngine.Object[] targetObjs, bool expandable);
        public static bool InspectorTitlebar(Rect position, bool foldout, Editor editor);
        public static void ProgressBar(Rect position, float value, string text);
        public static void HelpBox(Rect position, string message, MessageType type);
        public static Rect PrefixLabel(Rect totalPosition, GUIContent label);
        public static Rect PrefixLabel(Rect totalPosition, GUIContent label, GUIStyle style);
        public static Rect PrefixLabel(Rect totalPosition, int id, GUIContent label);
        public static Rect PrefixLabel(Rect totalPosition, int id, GUIContent label, GUIStyle style);
        public static GUIContent BeginProperty(Rect totalPosition, GUIContent label, SerializedProperty property);
        public static void EndProperty();
        public static float GetPropertyHeight(SerializedPropertyType type, GUIContent label);
        public static bool CanCacheInspectorGUI(SerializedProperty property);
        public static bool DropdownButton(Rect position, GUIContent content, FocusType focusType);
        public static bool DropdownButton(Rect position, GUIContent content, FocusType focusType, GUIStyle style);
        public static void DrawTextureAlpha(Rect position, Texture image, [DefaultValue("ScaleMode.StretchToFill")] ScaleMode scaleMode, [DefaultValue("0")] float imageAspect, [DefaultValue("-1")] float mipLevel);
        [ExcludeFromDocs]
        public static void DrawTextureAlpha(Rect position, Texture image);
        [ExcludeFromDocs]
        public static void DrawTextureAlpha(Rect position, Texture image, ScaleMode scaleMode);
        [ExcludeFromDocs]
        public static void DrawTextureAlpha(Rect position, Texture image, ScaleMode scaleMode, float imageAspect);
        public static void DrawTextureTransparent(Rect position, Texture image, [DefaultValue("ScaleMode.StretchToFill")] ScaleMode scaleMode, [DefaultValue("0")] float imageAspect, [DefaultValue("-1")] float mipLevel, [DefaultValue("ColorWriteMask.All")] ColorWriteMask colorWriteMask, [DefaultValue("0")] float exposure);
        [ExcludeFromDocs]
        public static void DrawTextureTransparent(Rect position, Texture image, ScaleMode scaleMode);
        [ExcludeFromDocs]
        public static void DrawTextureTransparent(Rect position, Texture image);
        [ExcludeFromDocs]
        public static void DrawTextureTransparent(Rect position, Texture image, ScaleMode scaleMode, float imageAspect);
        [ExcludeFromDocs]
        public static void DrawTextureTransparent(Rect position, Texture image, ScaleMode scaleMode, float imageAspect, float mipLevel);
        [ExcludeFromDocs]
        public static void DrawTextureTransparent(Rect position, Texture image, ScaleMode scaleMode, float imageAspect, float mipLevel, ColorWriteMask colorWriteMask);
        public static void DrawPreviewTexture(Rect position, Texture image, [DefaultValue("null")] Material mat, [DefaultValue("ScaleMode.StretchToFill")] ScaleMode scaleMode, [DefaultValue("0")] float imageAspect, [DefaultValue("-1")] float mipLevel, [DefaultValue("ColorWriteMask.All")] ColorWriteMask colorWriteMask, [DefaultValue("0")] float exposure);
        [ExcludeFromDocs]
        public static void DrawPreviewTexture(Rect position, Texture image, Material mat, ScaleMode scaleMode, float imageAspect, float mipLevel, ColorWriteMask colorWriteMask);
        [ExcludeFromDocs]
        public static void DrawPreviewTexture(Rect position, Texture image, Material mat, ScaleMode scaleMode, float imageAspect, float mipLevel);
        [ExcludeFromDocs]
        public static void DrawPreviewTexture(Rect position, Texture image, Material mat, ScaleMode scaleMode, float imageAspect);
        [ExcludeFromDocs]
        public static void DrawPreviewTexture(Rect position, Texture image, Material mat, ScaleMode scaleMode);
        [ExcludeFromDocs]
        public static void DrawPreviewTexture(Rect position, Texture image, Material mat);
        [ExcludeFromDocs]
        public static void DrawPreviewTexture(Rect position, Texture image);
        [ExcludeFromDocs]
        public static void LabelField(Rect position, string label);
        public static void LabelField(Rect position, string label, [DefaultValue("EditorStyles.label")] GUIStyle style);
        [ExcludeFromDocs]
        public static void LabelField(Rect position, GUIContent label);
        public static void LabelField(Rect position, GUIContent label, [DefaultValue("EditorStyles.label")] GUIStyle style);
        [ExcludeFromDocs]
        public static void LabelField(Rect position, string label, string label2);
        public static void LabelField(Rect position, string label, string label2, [DefaultValue("EditorStyles.label")] GUIStyle style);
        [ExcludeFromDocs]
        public static void LabelField(Rect position, GUIContent label, GUIContent label2);
        public static void LabelField(Rect position, GUIContent label, GUIContent label2, [DefaultValue("EditorStyles.label")] GUIStyle style);
        public static bool LinkButton(Rect position, string label);
        public static bool LinkButton(Rect position, GUIContent label);
        [ExcludeFromDocs]
        public static bool ToggleLeft(Rect position, string label, bool value);
        public static bool ToggleLeft(Rect position, string label, bool value, [DefaultValue("EditorStyles.label")] GUIStyle labelStyle);
        [ExcludeFromDocs]
        public static bool ToggleLeft(Rect position, GUIContent label, bool value);
        public static bool ToggleLeft(Rect position, GUIContent label, bool value, [DefaultValue("EditorStyles.label")] GUIStyle labelStyle);
        [ExcludeFromDocs]
        public static string TextField(Rect position, string text);
        public static string TextField(Rect position, string text, [DefaultValue("EditorStyles.textField")] GUIStyle style);
        [ExcludeFromDocs]
        public static string TextField(Rect position, string label, string text);
        public static string TextField(Rect position, string label, string text, [DefaultValue("EditorStyles.textField")] GUIStyle style);
        [ExcludeFromDocs]
        public static string TextField(Rect position, GUIContent label, string text);
        public static string TextField(Rect position, GUIContent label, string text, [DefaultValue("EditorStyles.textField")] GUIStyle style);
        [ExcludeFromDocs]
        public static string DelayedTextField(Rect position, string text);
        public static string DelayedTextField(Rect position, string text, [DefaultValue("EditorStyles.textField")] GUIStyle style);
        [ExcludeFromDocs]
        public static string DelayedTextField(Rect position, string label, string text);
        public static string DelayedTextField(Rect position, string label, string text, [DefaultValue("EditorStyles.textField")] GUIStyle style);
        [ExcludeFromDocs]
        public static string DelayedTextField(Rect position, GUIContent label, string text);
        public static string DelayedTextField(Rect position, GUIContent label, string text, [DefaultValue("EditorStyles.textField")] GUIStyle style);
        [ExcludeFromDocs]
        public static void DelayedTextField(Rect position, SerializedProperty property);
        public static void DelayedTextField(Rect position, SerializedProperty property, [DefaultValue("null")] GUIContent label);
        [ExcludeFromDocs]
        public static string DelayedTextField(Rect position, GUIContent label, int controlId, string text);
        public static string DelayedTextField(Rect position, GUIContent label, int controlId, string text, [DefaultValue("EditorStyles.textField")] GUIStyle style);
        [ExcludeFromDocs]
        public static string TextArea(Rect position, string text);
        public static string TextArea(Rect position, string text, [DefaultValue("EditorStyles.textField")] GUIStyle style);
        [ExcludeFromDocs]
        public static void SelectableLabel(Rect position, string text);
        public static void SelectableLabel(Rect position, string text, [DefaultValue("EditorStyles.label")] GUIStyle style);
        [ExcludeFromDocs]
        public static string PasswordField(Rect position, string password);
        public static string PasswordField(Rect position, string password, [DefaultValue("EditorStyles.textField")] GUIStyle style);
        [ExcludeFromDocs]
        public static string PasswordField(Rect position, string label, string password);
        public static string PasswordField(Rect position, string label, string password, [DefaultValue("EditorStyles.textField")] GUIStyle style);
        [ExcludeFromDocs]
        public static string PasswordField(Rect position, GUIContent label, string password);
        public static string PasswordField(Rect position, GUIContent label, string password, [DefaultValue("EditorStyles.textField")] GUIStyle style);
        [ExcludeFromDocs]
        public static float FloatField(Rect position, float value);
        public static float FloatField(Rect position, float value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static float FloatField(Rect position, string label, float value);
        public static float FloatField(Rect position, string label, float value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static float FloatField(Rect position, GUIContent label, float value);
        public static float FloatField(Rect position, GUIContent label, float value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static float DelayedFloatField(Rect position, float value);
        public static float DelayedFloatField(Rect position, float value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static float DelayedFloatField(Rect position, string label, float value);
        public static float DelayedFloatField(Rect position, string label, float value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static float DelayedFloatField(Rect position, GUIContent label, float value);
        public static float DelayedFloatField(Rect position, GUIContent label, float value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static void DelayedFloatField(Rect position, SerializedProperty property);
        public static void DelayedFloatField(Rect position, SerializedProperty property, [DefaultValue("null")] GUIContent label);
        [ExcludeFromDocs]
        public static double DoubleField(Rect position, double value);
        public static double DoubleField(Rect position, double value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static double DoubleField(Rect position, string label, double value);
        public static double DoubleField(Rect position, string label, double value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static double DoubleField(Rect position, GUIContent label, double value);
        public static double DoubleField(Rect position, GUIContent label, double value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static double DelayedDoubleField(Rect position, double value);
        public static double DelayedDoubleField(Rect position, double value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static double DelayedDoubleField(Rect position, string label, double value);
        public static double DelayedDoubleField(Rect position, string label, double value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static double DelayedDoubleField(Rect position, GUIContent label, double value);
        public static double DelayedDoubleField(Rect position, GUIContent label, double value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static int IntField(Rect position, int value);
        public static int IntField(Rect position, int value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static int IntField(Rect position, string label, int value);
        public static int IntField(Rect position, string label, int value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static int IntField(Rect position, GUIContent label, int value);
        public static int IntField(Rect position, GUIContent label, int value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static int DelayedIntField(Rect position, int value);
        public static int DelayedIntField(Rect position, int value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static int DelayedIntField(Rect position, string label, int value);
        public static int DelayedIntField(Rect position, string label, int value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static int DelayedIntField(Rect position, GUIContent label, int value);
        public static int DelayedIntField(Rect position, GUIContent label, int value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static void DelayedIntField(Rect position, SerializedProperty property);
        public static void DelayedIntField(Rect position, SerializedProperty property, [DefaultValue("null")] GUIContent label);
        [ExcludeFromDocs]
        public static long LongField(Rect position, long value);
        public static long LongField(Rect position, long value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static long LongField(Rect position, string label, long value);
        public static long LongField(Rect position, string label, long value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static long LongField(Rect position, GUIContent label, long value);
        public static long LongField(Rect position, GUIContent label, long value, [DefaultValue("EditorStyles.numberField")] GUIStyle style);
        [ExcludeFromDocs]
        public static int Popup(Rect position, int selectedIndex, string[] displayedOptions);
        public static int Popup(Rect position, int selectedIndex, string[] displayedOptions, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static int Popup(Rect position, int selectedIndex, GUIContent[] displayedOptions);
        public static int Popup(Rect position, int selectedIndex, GUIContent[] displayedOptions, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static int Popup(Rect position, string label, int selectedIndex, string[] displayedOptions);
        public static int Popup(Rect position, string label, int selectedIndex, string[] displayedOptions, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static int Popup(Rect position, GUIContent label, int selectedIndex, GUIContent[] displayedOptions);
        public static int Popup(Rect position, GUIContent label, int selectedIndex, GUIContent[] displayedOptions, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static Enum EnumPopup(Rect position, Enum selected);
        public static Enum EnumPopup(Rect position, Enum selected, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static Enum EnumPopup(Rect position, string label, Enum selected);
        public static Enum EnumPopup(Rect position, string label, Enum selected, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static Enum EnumPopup(Rect position, GUIContent label, Enum selected);
        public static Enum EnumPopup(Rect position, GUIContent label, Enum selected, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        public static Enum EnumPopup(Rect position, GUIContent label, Enum selected, [DefaultValue("null")] Func<Enum, bool> checkEnabled, [DefaultValue("false")] bool includeObsolete = False, [DefaultValue("null")] GUIStyle style = null);
        [ExcludeFromDocs]
        public static int IntPopup(Rect position, int selectedValue, string[] displayedOptions, int[] optionValues);
        public static int IntPopup(Rect position, int selectedValue, string[] displayedOptions, int[] optionValues, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static int IntPopup(Rect position, int selectedValue, GUIContent[] displayedOptions, int[] optionValues);
        public static int IntPopup(Rect position, int selectedValue, GUIContent[] displayedOptions, int[] optionValues, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static int IntPopup(Rect position, GUIContent label, int selectedValue, GUIContent[] displayedOptions, int[] optionValues);
        public static int IntPopup(Rect position, GUIContent label, int selectedValue, GUIContent[] displayedOptions, int[] optionValues, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static void IntPopup(Rect position, SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues);
        public static void IntPopup(Rect position, SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues, [DefaultValue("null")] GUIContent label);
        [ExcludeFromDocs]
        public static int IntPopup(Rect position, string label, int selectedValue, string[] displayedOptions, int[] optionValues);
        public static int IntPopup(Rect position, string label, int selectedValue, string[] displayedOptions, int[] optionValues, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static string TagField(Rect position, string tag);
        public static string TagField(Rect position, string tag, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static string TagField(Rect position, string label, string tag);
        public static string TagField(Rect position, string label, string tag, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static string TagField(Rect position, GUIContent label, string tag);
        public static string TagField(Rect position, GUIContent label, string tag, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static int LayerField(Rect position, int layer);
        public static int LayerField(Rect position, int layer, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static int LayerField(Rect position, string label, int layer);
        public static int LayerField(Rect position, string label, int layer, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static int LayerField(Rect position, GUIContent label, int layer);
        public static int LayerField(Rect position, GUIContent label, int layer, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static int MaskField(Rect position, GUIContent label, int mask, string[] displayedOptions);
        public static int MaskField(Rect position, GUIContent label, int mask, string[] displayedOptions, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static int MaskField(Rect position, string label, int mask, string[] displayedOptions);
        public static int MaskField(Rect position, string label, int mask, string[] displayedOptions, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static int MaskField(Rect position, int mask, string[] displayedOptions);
        public static int MaskField(Rect position, int mask, string[] displayedOptions, [DefaultValue("EditorStyles.popup")] GUIStyle style);
        [ExcludeFromDocs]
        public static bool Foldout(Rect position, bool foldout, string content);
        public static bool Foldout(Rect position, bool foldout, string content, [DefaultValue("EditorStyles.foldout")] GUIStyle style);
        [ExcludeFromDocs]
        public static bool Foldout(Rect position, bool foldout, string content, bool toggleOnLabelClick);
        public static bool Foldout(Rect position, bool foldout, string content, bool toggleOnLabelClick, [DefaultValue("EditorStyles.foldout")] GUIStyle style);
        [ExcludeFromDocs]
        public static bool Foldout(Rect position, bool foldout, GUIContent content);
        public static bool Foldout(Rect position, bool foldout, GUIContent content, [DefaultValue("EditorStyles.foldout")] GUIStyle style);
        [ExcludeFromDocs]
        public static bool Foldout(Rect position, bool foldout, GUIContent content, bool toggleOnLabelClick);
        public static bool Foldout(Rect position, bool foldout, GUIContent content, bool toggleOnLabelClick, [DefaultValue("EditorStyles.foldout")] GUIStyle style);
        [ExcludeFromDocs]
        public static void HandlePrefixLabel(Rect totalPosition, Rect labelPosition, GUIContent label, int id);
        [ExcludeFromDocs]
        public static void HandlePrefixLabel(Rect totalPosition, Rect labelPosition, GUIContent label);
        public static void HandlePrefixLabel(Rect totalPosition, Rect labelPosition, GUIContent label, [DefaultValue("0")] int id, [DefaultValue("EditorStyles.label")] GUIStyle style);
        public static float GetPropertyHeight(SerializedProperty property, bool includeChildren);
        [ExcludeFromDocs]
        public static float GetPropertyHeight(SerializedProperty property, GUIContent label);
        [ExcludeFromDocs]
        public static float GetPropertyHeight(SerializedProperty property);
        public static float GetPropertyHeight(SerializedProperty property, [DefaultValue("null")] GUIContent label, [DefaultValue("true")] bool includeChildren);
        [ExcludeFromDocs]
        public static bool PropertyField(Rect position, SerializedProperty property);
        public static bool PropertyField(Rect position, SerializedProperty property, [DefaultValue("false")] bool includeChildren);
        [ExcludeFromDocs]
        public static bool PropertyField(Rect position, SerializedProperty property, GUIContent label);
        public static bool PropertyField(Rect position, SerializedProperty property, GUIContent label, [DefaultValue("false")] bool includeChildren);
        [Obsolete("EnumMaskField has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskField(Rect position, Enum enumValue);
        [Obsolete("EnumMaskField has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskField(Rect position, Enum enumValue, GUIStyle style);
        [Obsolete("EnumMaskField has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskField(Rect position, string label, Enum enumValue);
        [Obsolete("EnumMaskField has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskField(Rect position, string label, Enum enumValue, GUIStyle style);
        [Obsolete("EnumMaskField has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskField(Rect position, GUIContent label, Enum enumValue);
        [Obsolete("EnumMaskField has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskField(Rect position, GUIContent label, Enum enumValue, GUIStyle style);
        [Obsolete("EnumMaskPopup has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskPopup(Rect position, string label, Enum selected);
        [Obsolete("EnumMaskPopup has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskPopup(Rect position, string label, Enum selected, GUIStyle style);
        [Obsolete("EnumMaskPopup has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskPopup(Rect position, GUIContent label, Enum selected);
        [Obsolete("EnumMaskPopup has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskPopup(Rect position, GUIContent label, Enum selected, GUIStyle style);
        public static bool BeginFoldoutHeaderGroup(Rect position, bool foldout, string content, [DefaultValue("EditorStyles.foldoutHeader")] GUIStyle style = null, Action<Rect> menuAction = null, GUIStyle menuIcon = null);
        public static bool BeginFoldoutHeaderGroup(Rect position, bool foldout, GUIContent content, [DefaultValue("EditorStyles.foldoutHeader")] GUIStyle style = null, Action<Rect> menuAction = null, GUIStyle menuIcon = null);
        public static void EndFoldoutHeaderGroup();
        public static Gradient GradientField(Rect position, Gradient gradient);
        public static Gradient GradientField(Rect position, string label, Gradient gradient);
        public static Gradient GradientField(Rect position, GUIContent label, Gradient gradient);
        public static Gradient GradientField(Rect position, GUIContent label, Gradient gradient, bool hdr);
        public static Gradient GradientField(Rect position, GUIContent label, Gradient gradient, bool hdr, ColorSpace colorSpace);
        public static void DrawRect(Rect rect, Color color);

        public class DisabledGroupScope : GUI.Scope
        {
            public DisabledGroupScope(bool disabled);

            protected override void CloseScope();
        }
        public struct DisabledScope : IDisposable
        {
            public DisabledScope(bool disabled);

            public void Dispose();
        }
        public class ChangeCheckScope : GUI.Scope
        {
            public ChangeCheckScope();

            public bool changed { get; }

            protected override void CloseScope();
        }
        public class IndentLevelScope : GUI.Scope
        {
            public IndentLevelScope();
            public IndentLevelScope(int increment);

            protected override void CloseScope();
        }
        public class PropertyScope : GUI.Scope
        {
            public PropertyScope(Rect totalPosition, GUIContent label, SerializedProperty property);

            public GUIContent content { get; protected set; }

            protected override void CloseScope();
        }
    }
}
