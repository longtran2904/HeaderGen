#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;
using UnityEngine.Internal;

namespace UnityEditor
{
    public sealed class EditorGUILayout
    {
        public EditorGUILayout();

        [Obsolete("EnumMaskField has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskField(Enum enumValue, params GUILayoutOption[] options);
        [Obsolete("EnumMaskField has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskField(Enum enumValue, GUIStyle style, params GUILayoutOption[] options);
        [Obsolete("EnumMaskField has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskField(string label, Enum enumValue, params GUILayoutOption[] options);
        [Obsolete("EnumMaskField has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskField(string label, Enum enumValue, GUIStyle style, params GUILayoutOption[] options);
        [Obsolete("EnumMaskField has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskField(GUIContent label, Enum enumValue, params GUILayoutOption[] options);
        [Obsolete("EnumMaskField has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskField(GUIContent label, Enum enumValue, GUIStyle style, params GUILayoutOption[] options);
        [Obsolete("EnumMaskPopup has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskPopup(string label, Enum selected, params GUILayoutOption[] options);
        [Obsolete("EnumMaskPopup has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskPopup(string label, Enum selected, GUIStyle style, params GUILayoutOption[] options);
        [Obsolete("EnumMaskPopup has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskPopup(GUIContent label, Enum selected, params GUILayoutOption[] options);
        [Obsolete("EnumMaskPopup has been deprecated. Use EnumFlagsField instead.")]
        public static Enum EnumMaskPopup(GUIContent label, Enum selected, GUIStyle style, params GUILayoutOption[] options);
        [ExcludeFromDocs]
        public static bool Foldout(bool foldout, string content);
        public static bool Foldout(bool foldout, string content, [DefaultValue("EditorStyles.foldout")] GUIStyle style);
        [ExcludeFromDocs]
        public static bool Foldout(bool foldout, GUIContent content);
        public static bool Foldout(bool foldout, GUIContent content, [DefaultValue("EditorStyles.foldout")] GUIStyle style);
        [ExcludeFromDocs]
        public static bool Foldout(bool foldout, string content, bool toggleOnLabelClick);
        public static bool Foldout(bool foldout, string content, bool toggleOnLabelClick, [DefaultValue("EditorStyles.foldout")] GUIStyle style);
        [ExcludeFromDocs]
        public static bool Foldout(bool foldout, GUIContent content, bool toggleOnLabelClick);
        public static bool Foldout(bool foldout, GUIContent content, bool toggleOnLabelClick, [DefaultValue("EditorStyles.foldout")] GUIStyle style);
        [ExcludeFromDocs]
        public static void PrefixLabel(string label);
        public static void PrefixLabel(string label, [DefaultValue("\"Button\"")] GUIStyle followingStyle);
        public static void PrefixLabel(string label, GUIStyle followingStyle, GUIStyle labelStyle);
        [ExcludeFromDocs]
        public static void PrefixLabel(GUIContent label);
        public static void PrefixLabel(GUIContent label, [DefaultValue("\"Button\"")] GUIStyle followingStyle);
        public static void PrefixLabel(GUIContent label, GUIStyle followingStyle, GUIStyle labelStyle);
        public static void LabelField(string label, params GUILayoutOption[] options);
        public static void LabelField(string label, GUIStyle style, params GUILayoutOption[] options);
        public static void LabelField(GUIContent label, params GUILayoutOption[] options);
        public static void LabelField(GUIContent label, GUIStyle style, params GUILayoutOption[] options);
        public static void LabelField(string label, string label2, params GUILayoutOption[] options);
        public static void LabelField(string label, string label2, GUIStyle style, params GUILayoutOption[] options);
        public static void LabelField(GUIContent label, GUIContent label2, params GUILayoutOption[] options);
        public static void LabelField(GUIContent label, GUIContent label2, GUIStyle style, params GUILayoutOption[] options);
        public static bool LinkButton(string label, params GUILayoutOption[] options);
        public static bool LinkButton(GUIContent label, params GUILayoutOption[] options);
        public static bool Toggle(bool value, params GUILayoutOption[] options);
        public static bool Toggle(string label, bool value, params GUILayoutOption[] options);
        public static bool Toggle(GUIContent label, bool value, params GUILayoutOption[] options);
        public static bool Toggle(bool value, GUIStyle style, params GUILayoutOption[] options);
        public static bool Toggle(string label, bool value, GUIStyle style, params GUILayoutOption[] options);
        public static bool Toggle(GUIContent label, bool value, GUIStyle style, params GUILayoutOption[] options);
        public static bool ToggleLeft(string label, bool value, params GUILayoutOption[] options);
        public static bool ToggleLeft(GUIContent label, bool value, params GUILayoutOption[] options);
        public static bool ToggleLeft(string label, bool value, GUIStyle labelStyle, params GUILayoutOption[] options);
        public static bool ToggleLeft(GUIContent label, bool value, GUIStyle labelStyle, params GUILayoutOption[] options);
        public static string TextField(string text, params GUILayoutOption[] options);
        public static string TextField(string text, GUIStyle style, params GUILayoutOption[] options);
        public static string TextField(string label, string text, params GUILayoutOption[] options);
        public static string TextField(string label, string text, GUIStyle style, params GUILayoutOption[] options);
        public static string TextField(GUIContent label, string text, params GUILayoutOption[] options);
        public static string TextField(GUIContent label, string text, GUIStyle style, params GUILayoutOption[] options);
        public static string DelayedTextField(string text, params GUILayoutOption[] options);
        public static string DelayedTextField(string text, GUIStyle style, params GUILayoutOption[] options);
        public static string DelayedTextField(string label, string text, params GUILayoutOption[] options);
        public static string DelayedTextField(string label, string text, GUIStyle style, params GUILayoutOption[] options);
        public static string DelayedTextField(GUIContent label, string text, params GUILayoutOption[] options);
        public static string DelayedTextField(GUIContent label, string text, GUIStyle style, params GUILayoutOption[] options);
        public static void DelayedTextField(SerializedProperty property, params GUILayoutOption[] options);
        public static void DelayedTextField(SerializedProperty property, GUIContent label, params GUILayoutOption[] options);
        public static string TextArea(string text, params GUILayoutOption[] options);
        public static string TextArea(string text, GUIStyle style, params GUILayoutOption[] options);
        public static void SelectableLabel(string text, params GUILayoutOption[] options);
        public static void SelectableLabel(string text, GUIStyle style, params GUILayoutOption[] options);
        public static string PasswordField(string password, params GUILayoutOption[] options);
        public static string PasswordField(string password, GUIStyle style, params GUILayoutOption[] options);
        public static string PasswordField(string label, string password, params GUILayoutOption[] options);
        public static string PasswordField(string label, string password, GUIStyle style, params GUILayoutOption[] options);
        public static string PasswordField(GUIContent label, string password, params GUILayoutOption[] options);
        public static string PasswordField(GUIContent label, string password, GUIStyle style, params GUILayoutOption[] options);
        public static float FloatField(float value, params GUILayoutOption[] options);
        public static float FloatField(float value, GUIStyle style, params GUILayoutOption[] options);
        public static float FloatField(string label, float value, params GUILayoutOption[] options);
        public static float FloatField(string label, float value, GUIStyle style, params GUILayoutOption[] options);
        public static float FloatField(GUIContent label, float value, params GUILayoutOption[] options);
        public static float FloatField(GUIContent label, float value, GUIStyle style, params GUILayoutOption[] options);
        public static float DelayedFloatField(float value, params GUILayoutOption[] options);
        public static float DelayedFloatField(float value, GUIStyle style, params GUILayoutOption[] options);
        public static float DelayedFloatField(string label, float value, params GUILayoutOption[] options);
        public static float DelayedFloatField(string label, float value, GUIStyle style, params GUILayoutOption[] options);
        public static float DelayedFloatField(GUIContent label, float value, params GUILayoutOption[] options);
        public static float DelayedFloatField(GUIContent label, float value, GUIStyle style, params GUILayoutOption[] options);
        public static void DelayedFloatField(SerializedProperty property, params GUILayoutOption[] options);
        public static void DelayedFloatField(SerializedProperty property, GUIContent label, params GUILayoutOption[] options);
        public static double DoubleField(double value, params GUILayoutOption[] options);
        public static double DoubleField(double value, GUIStyle style, params GUILayoutOption[] options);
        public static double DoubleField(string label, double value, params GUILayoutOption[] options);
        public static double DoubleField(string label, double value, GUIStyle style, params GUILayoutOption[] options);
        public static double DoubleField(GUIContent label, double value, params GUILayoutOption[] options);
        public static double DoubleField(GUIContent label, double value, GUIStyle style, params GUILayoutOption[] options);
        public static double DelayedDoubleField(double value, params GUILayoutOption[] options);
        public static double DelayedDoubleField(double value, GUIStyle style, params GUILayoutOption[] options);
        public static double DelayedDoubleField(string label, double value, params GUILayoutOption[] options);
        public static double DelayedDoubleField(string label, double value, GUIStyle style, params GUILayoutOption[] options);
        public static double DelayedDoubleField(GUIContent label, double value, params GUILayoutOption[] options);
        public static double DelayedDoubleField(GUIContent label, double value, GUIStyle style, params GUILayoutOption[] options);
        public static int IntField(int value, params GUILayoutOption[] options);
        public static int IntField(int value, GUIStyle style, params GUILayoutOption[] options);
        public static int IntField(string label, int value, params GUILayoutOption[] options);
        public static int IntField(string label, int value, GUIStyle style, params GUILayoutOption[] options);
        public static int IntField(GUIContent label, int value, params GUILayoutOption[] options);
        public static int IntField(GUIContent label, int value, GUIStyle style, params GUILayoutOption[] options);
        public static int DelayedIntField(int value, params GUILayoutOption[] options);
        public static int DelayedIntField(int value, GUIStyle style, params GUILayoutOption[] options);
        public static int DelayedIntField(string label, int value, params GUILayoutOption[] options);
        public static int DelayedIntField(string label, int value, GUIStyle style, params GUILayoutOption[] options);
        public static int DelayedIntField(GUIContent label, int value, params GUILayoutOption[] options);
        public static int DelayedIntField(GUIContent label, int value, GUIStyle style, params GUILayoutOption[] options);
        public static void DelayedIntField(SerializedProperty property, params GUILayoutOption[] options);
        public static void DelayedIntField(SerializedProperty property, GUIContent label, params GUILayoutOption[] options);
        public static long LongField(long value, params GUILayoutOption[] options);
        public static long LongField(long value, GUIStyle style, params GUILayoutOption[] options);
        public static long LongField(string label, long value, params GUILayoutOption[] options);
        public static long LongField(string label, long value, GUIStyle style, params GUILayoutOption[] options);
        public static long LongField(GUIContent label, long value, params GUILayoutOption[] options);
        public static long LongField(GUIContent label, long value, GUIStyle style, params GUILayoutOption[] options);
        public static float Slider(float value, float leftValue, float rightValue, params GUILayoutOption[] options);
        public static float Slider(string label, float value, float leftValue, float rightValue, params GUILayoutOption[] options);
        public static float Slider(GUIContent label, float value, float leftValue, float rightValue, params GUILayoutOption[] options);
        public static void Slider(SerializedProperty property, float leftValue, float rightValue, params GUILayoutOption[] options);
        public static void Slider(SerializedProperty property, float leftValue, float rightValue, string label, params GUILayoutOption[] options);
        public static void Slider(SerializedProperty property, float leftValue, float rightValue, GUIContent label, params GUILayoutOption[] options);
        public static int IntSlider(int value, int leftValue, int rightValue, params GUILayoutOption[] options);
        public static int IntSlider(string label, int value, int leftValue, int rightValue, params GUILayoutOption[] options);
        public static int IntSlider(GUIContent label, int value, int leftValue, int rightValue, params GUILayoutOption[] options);
        public static void IntSlider(SerializedProperty property, int leftValue, int rightValue, params GUILayoutOption[] options);
        public static void IntSlider(SerializedProperty property, int leftValue, int rightValue, string label, params GUILayoutOption[] options);
        public static void IntSlider(SerializedProperty property, int leftValue, int rightValue, GUIContent label, params GUILayoutOption[] options);
        public static void MinMaxSlider(ref float minValue, ref float maxValue, float minLimit, float maxLimit, params GUILayoutOption[] options);
        public static void MinMaxSlider(string label, ref float minValue, ref float maxValue, float minLimit, float maxLimit, params GUILayoutOption[] options);
        public static void MinMaxSlider(GUIContent label, ref float minValue, ref float maxValue, float minLimit, float maxLimit, params GUILayoutOption[] options);
        public static int Popup(int selectedIndex, string[] displayedOptions, params GUILayoutOption[] options);
        public static int Popup(int selectedIndex, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options);
        public static int Popup(int selectedIndex, GUIContent[] displayedOptions, params GUILayoutOption[] options);
        public static int Popup(int selectedIndex, GUIContent[] displayedOptions, GUIStyle style, params GUILayoutOption[] options);
        public static int Popup(string label, int selectedIndex, string[] displayedOptions, params GUILayoutOption[] options);
        public static int Popup(GUIContent label, int selectedIndex, string[] displayedOptions, params GUILayoutOption[] options);
        public static int Popup(string label, int selectedIndex, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options);
        public static int Popup(GUIContent label, int selectedIndex, GUIContent[] displayedOptions, params GUILayoutOption[] options);
        public static int Popup(GUIContent label, int selectedIndex, GUIContent[] displayedOptions, GUIStyle style, params GUILayoutOption[] options);
        public static Enum EnumPopup(Enum selected, params GUILayoutOption[] options);
        public static Enum EnumPopup(Enum selected, GUIStyle style, params GUILayoutOption[] options);
        public static Enum EnumPopup(string label, Enum selected, params GUILayoutOption[] options);
        public static Enum EnumPopup(string label, Enum selected, GUIStyle style, params GUILayoutOption[] options);
        public static Enum EnumPopup(GUIContent label, Enum selected, params GUILayoutOption[] options);
        public static Enum EnumPopup(GUIContent label, Enum selected, GUIStyle style, params GUILayoutOption[] options);
        public static Enum EnumPopup(GUIContent label, Enum selected, Func<Enum, bool> checkEnabled, bool includeObsolete, params GUILayoutOption[] options);
        public static Enum EnumPopup(GUIContent label, Enum selected, Func<Enum, bool> checkEnabled, bool includeObsolete, GUIStyle style, params GUILayoutOption[] options);
        public static int IntPopup(int selectedValue, string[] displayedOptions, int[] optionValues, params GUILayoutOption[] options);
        public static int IntPopup(int selectedValue, string[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options);
        public static int IntPopup(int selectedValue, GUIContent[] displayedOptions, int[] optionValues, params GUILayoutOption[] options);
        public static int IntPopup(int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options);
        public static int IntPopup(string label, int selectedValue, string[] displayedOptions, int[] optionValues, params GUILayoutOption[] options);
        public static int IntPopup(string label, int selectedValue, string[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options);
        public static int IntPopup(GUIContent label, int selectedValue, GUIContent[] displayedOptions, int[] optionValues, params GUILayoutOption[] options);
        public static int IntPopup(GUIContent label, int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options);
        public static void IntPopup(SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues, params GUILayoutOption[] options);
        public static void IntPopup(SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues, GUIContent label, params GUILayoutOption[] options);
        [Obsolete("This function is obsolete and the style is not used.")]
        public static void IntPopup(SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues, GUIContent label, GUIStyle style, params GUILayoutOption[] options);
        public static string TagField(string tag, params GUILayoutOption[] options);
        public static string TagField(string tag, GUIStyle style, params GUILayoutOption[] options);
        public static string TagField(string label, string tag, params GUILayoutOption[] options);
        public static string TagField(string label, string tag, GUIStyle style, params GUILayoutOption[] options);
        public static string TagField(GUIContent label, string tag, params GUILayoutOption[] options);
        public static string TagField(GUIContent label, string tag, GUIStyle style, params GUILayoutOption[] options);
        public static int LayerField(int layer, params GUILayoutOption[] options);
        public static int LayerField(int layer, GUIStyle style, params GUILayoutOption[] options);
        public static int LayerField(string label, int layer, params GUILayoutOption[] options);
        public static int LayerField(string label, int layer, GUIStyle style, params GUILayoutOption[] options);
        public static int LayerField(GUIContent label, int layer, params GUILayoutOption[] options);
        public static int LayerField(GUIContent label, int layer, GUIStyle style, params GUILayoutOption[] options);
        public static int MaskField(GUIContent label, int mask, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options);
        public static int MaskField(string label, int mask, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options);
        public static int MaskField(GUIContent label, int mask, string[] displayedOptions, params GUILayoutOption[] options);
        public static int MaskField(string label, int mask, string[] displayedOptions, params GUILayoutOption[] options);
        public static int MaskField(int mask, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options);
        public static int MaskField(int mask, string[] displayedOptions, params GUILayoutOption[] options);
        public static Enum EnumFlagsField(Enum enumValue, params GUILayoutOption[] options);
        public static Enum EnumFlagsField(Enum enumValue, GUIStyle style, params GUILayoutOption[] options);
        public static Enum EnumFlagsField(string label, Enum enumValue, params GUILayoutOption[] options);
        public static Enum EnumFlagsField(string label, Enum enumValue, GUIStyle style, params GUILayoutOption[] options);
        public static Enum EnumFlagsField(GUIContent label, Enum enumValue, params GUILayoutOption[] options);
        public static Enum EnumFlagsField(GUIContent label, Enum enumValue, GUIStyle style, params GUILayoutOption[] options);
        public static Enum EnumFlagsField(GUIContent label, Enum enumValue, bool includeObsolete, params GUILayoutOption[] options);
        public static Enum EnumFlagsField(GUIContent label, Enum enumValue, bool includeObsolete, GUIStyle style, params GUILayoutOption[] options);
        [Obsolete("Check the docs for the usage of the new parameter 'allowSceneObjects'.")]
        public static UnityEngine.Object ObjectField(UnityEngine.Object obj, Type objType, params GUILayoutOption[] options);
        public static UnityEngine.Object ObjectField(UnityEngine.Object obj, Type objType, UnityEngine.Object targetBeingEdited, params GUILayoutOption[] options);
        public static UnityEngine.Object ObjectField(UnityEngine.Object obj, Type objType, bool allowSceneObjects, params GUILayoutOption[] options);
        [Obsolete("Check the docs for the usage of the new parameter 'allowSceneObjects'.")]
        public static UnityEngine.Object ObjectField(string label, UnityEngine.Object obj, Type objType, params GUILayoutOption[] options);
        public static UnityEngine.Object ObjectField(string label, UnityEngine.Object obj, Type objType, UnityEngine.Object targetBeingEdited, params GUILayoutOption[] options);
        public static UnityEngine.Object ObjectField(string label, UnityEngine.Object obj, Type objType, bool allowSceneObjects, params GUILayoutOption[] options);
        [Obsolete("Check the docs for the usage of the new parameter 'allowSceneObjects'.")]
        public static UnityEngine.Object ObjectField(GUIContent label, UnityEngine.Object obj, Type objType, params GUILayoutOption[] options);
        public static UnityEngine.Object ObjectField(GUIContent label, UnityEngine.Object obj, Type objType, UnityEngine.Object targetBeingEdited, params GUILayoutOption[] options);
        public static UnityEngine.Object ObjectField(GUIContent label, UnityEngine.Object obj, Type objType, bool allowSceneObjects, params GUILayoutOption[] options);
        public static void ObjectField(SerializedProperty property, params GUILayoutOption[] options);
        public static void ObjectField(SerializedProperty property, GUIContent label, params GUILayoutOption[] options);
        public static void ObjectField(SerializedProperty property, Type objType, params GUILayoutOption[] options);
        public static void ObjectField(SerializedProperty property, Type objType, GUIContent label, params GUILayoutOption[] options);
        public static Vector2 Vector2Field(string label, Vector2 value, params GUILayoutOption[] options);
        public static Vector2 Vector2Field(GUIContent label, Vector2 value, params GUILayoutOption[] options);
        public static Vector3 Vector3Field(string label, Vector3 value, params GUILayoutOption[] options);
        public static Vector3 Vector3Field(GUIContent label, Vector3 value, params GUILayoutOption[] options);
        public static Vector4 Vector4Field(string label, Vector4 value, params GUILayoutOption[] options);
        public static Vector4 Vector4Field(GUIContent label, Vector4 value, params GUILayoutOption[] options);
        public static Vector2Int Vector2IntField(string label, Vector2Int value, params GUILayoutOption[] options);
        public static Vector2Int Vector2IntField(GUIContent label, Vector2Int value, params GUILayoutOption[] options);
        public static Vector3Int Vector3IntField(string label, Vector3Int value, params GUILayoutOption[] options);
        public static Vector3Int Vector3IntField(GUIContent label, Vector3Int value, params GUILayoutOption[] options);
        public static Rect RectField(Rect value, params GUILayoutOption[] options);
        public static Rect RectField(string label, Rect value, params GUILayoutOption[] options);
        public static Rect RectField(GUIContent label, Rect value, params GUILayoutOption[] options);
        public static RectInt RectIntField(RectInt value, params GUILayoutOption[] options);
        public static RectInt RectIntField(string label, RectInt value, params GUILayoutOption[] options);
        public static RectInt RectIntField(GUIContent label, RectInt value, params GUILayoutOption[] options);
        public static Bounds BoundsField(Bounds value, params GUILayoutOption[] options);
        public static Bounds BoundsField(string label, Bounds value, params GUILayoutOption[] options);
        public static Bounds BoundsField(GUIContent label, Bounds value, params GUILayoutOption[] options);
        public static BoundsInt BoundsIntField(BoundsInt value, params GUILayoutOption[] options);
        public static BoundsInt BoundsIntField(string label, BoundsInt value, params GUILayoutOption[] options);
        public static BoundsInt BoundsIntField(GUIContent label, BoundsInt value, params GUILayoutOption[] options);
        public static Color ColorField(Color value, params GUILayoutOption[] options);
        public static Color ColorField(string label, Color value, params GUILayoutOption[] options);
        public static Color ColorField(GUIContent label, Color value, params GUILayoutOption[] options);
        [Obsolete("Use EditorGUILayout.ColorField(GUIContent label, Color value, bool showEyedropper, bool showAlpha, bool hdr, params GUILayoutOption[] options)")]
        public static Color ColorField(GUIContent label, Color value, bool showEyedropper, bool showAlpha, bool hdr, ColorPickerHDRConfig hdrConfig, params GUILayoutOption[] options);
        public static Color ColorField(GUIContent label, Color value, bool showEyedropper, bool showAlpha, bool hdr, params GUILayoutOption[] options);
        public static AnimationCurve CurveField(AnimationCurve value, params GUILayoutOption[] options);
        public static AnimationCurve CurveField(string label, AnimationCurve value, params GUILayoutOption[] options);
        public static AnimationCurve CurveField(GUIContent label, AnimationCurve value, params GUILayoutOption[] options);
        public static AnimationCurve CurveField(AnimationCurve value, Color color, Rect ranges, params GUILayoutOption[] options);
        public static AnimationCurve CurveField(string label, AnimationCurve value, Color color, Rect ranges, params GUILayoutOption[] options);
        public static AnimationCurve CurveField(GUIContent label, AnimationCurve value, Color color, Rect ranges, params GUILayoutOption[] options);
        public static void CurveField(SerializedProperty property, Color color, Rect ranges, params GUILayoutOption[] options);
        public static void CurveField(SerializedProperty property, Color color, Rect ranges, GUIContent label, params GUILayoutOption[] options);
        public static bool InspectorTitlebar(bool foldout, UnityEngine.Object targetObj);
        public static bool InspectorTitlebar(bool foldout, UnityEngine.Object targetObj, bool expandable);
        public static bool InspectorTitlebar(bool foldout, UnityEngine.Object[] targetObjs);
        public static bool InspectorTitlebar(bool foldout, UnityEngine.Object[] targetObjs, bool expandable);
        public static bool InspectorTitlebar(bool foldout, Editor editor);
        public static void InspectorTitlebar(UnityEngine.Object[] targetObjs);
        public static void HelpBox(string message, MessageType type);
        public static void HelpBox(string message, MessageType type, bool wide);
        public static void HelpBox(GUIContent content, bool wide = True);
        public static void Space();
        public static void Space(float width);
        public static void Space(float width, bool expand);
        public static void Separator();
        public static bool BeginToggleGroup(string label, bool toggle);
        public static bool BeginToggleGroup(GUIContent label, bool toggle);
        public static void EndToggleGroup();
        public static Rect BeginHorizontal(params GUILayoutOption[] options);
        public static Rect BeginHorizontal(GUIStyle style, params GUILayoutOption[] options);
        public static void EndHorizontal();
        public static Rect BeginVertical(params GUILayoutOption[] options);
        public static Rect BeginVertical(GUIStyle style, params GUILayoutOption[] options);
        public static void EndVertical();
        public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options);
        public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options);
        public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options);
        public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options);
        public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options);
        public static void EndScrollView();
        public static bool PropertyField(SerializedProperty property, params GUILayoutOption[] options);
        public static bool PropertyField(SerializedProperty property, GUIContent label, params GUILayoutOption[] options);
        public static bool PropertyField(SerializedProperty property, bool includeChildren, params GUILayoutOption[] options);
        public static bool PropertyField(SerializedProperty property, GUIContent label, bool includeChildren, params GUILayoutOption[] options);
        public static Rect GetControlRect(params GUILayoutOption[] options);
        public static Rect GetControlRect(bool hasLabel, params GUILayoutOption[] options);
        public static Rect GetControlRect(bool hasLabel, float height, params GUILayoutOption[] options);
        public static Rect GetControlRect(bool hasLabel, float height, GUIStyle style, params GUILayoutOption[] options);
        public static bool BeginFadeGroup(float value);
        public static void EndFadeGroup();
        public static BuildTargetGroup BeginBuildTargetSelectionGrouping();
        public static void EndBuildTargetSelectionGrouping();
        public static bool DropdownButton(GUIContent content, FocusType focusType, params GUILayoutOption[] options);
        public static bool DropdownButton(GUIContent content, FocusType focusType, GUIStyle style, params GUILayoutOption[] options);
        public static bool BeginFoldoutHeaderGroup(bool foldout, string content, [DefaultValue("EditorStyles.foldoutHeader")] GUIStyle style = null, Action<Rect> menuAction = null, GUIStyle menuIcon = null);
        public static bool BeginFoldoutHeaderGroup(bool foldout, GUIContent content, [DefaultValue("EditorStyles.foldoutHeader")] GUIStyle style = null, Action<Rect> menuAction = null, GUIStyle menuIcon = null);
        public static void EndFoldoutHeaderGroup();
        public static Gradient GradientField(Gradient value, params GUILayoutOption[] options);
        public static Gradient GradientField(string label, Gradient value, params GUILayoutOption[] options);
        public static Gradient GradientField(GUIContent label, Gradient value, params GUILayoutOption[] options);
        public static Gradient GradientField(GUIContent label, Gradient value, bool hdr, params GUILayoutOption[] options);
        public static float Knob(Vector2 knobSize, float value, float minValue, float maxValue, string unit, Color backgroundColor, Color activeColor, bool showValue, params GUILayoutOption[] options);
        public static void EditorToolbarForTarget(UnityEngine.Object target);
        public static void EditorToolbarForTarget(GUIContent content, UnityEngine.Object target);
        public static void ToolContextToolbarForTarget(GUIContent content, UnityEngine.Object target);
        public static void EditorToolbar(params EditorTool[] tools);
        public static void EditorToolbar<T>(IList<T> tools) where T : EditorTool;
        public static void ToolContextToolbar<T>(GUIContent content, IList<T> contexts) where T : EditorToolContext;

        public class ToggleGroupScope : GUI.Scope
        {
            public ToggleGroupScope(string label, bool toggle);
            public ToggleGroupScope(GUIContent label, bool toggle);

            public bool enabled { get; protected set; }

            protected override void CloseScope();
        }
        public class HorizontalScope : GUI.Scope
        {
            public HorizontalScope(params GUILayoutOption[] options);
            public HorizontalScope(GUIStyle style, params GUILayoutOption[] options);

            public Rect rect { get; protected set; }

            protected override void CloseScope();
        }
        public class VerticalScope : GUI.Scope
        {
            public VerticalScope(params GUILayoutOption[] options);
            public VerticalScope(GUIStyle style, params GUILayoutOption[] options);

            public Rect rect { get; protected set; }

            protected override void CloseScope();
        }
        public class ScrollViewScope : GUI.Scope
        {
            public ScrollViewScope(Vector2 scrollPosition, params GUILayoutOption[] options);
            public ScrollViewScope(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options);
            public ScrollViewScope(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options);
            public ScrollViewScope(Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options);
            public ScrollViewScope(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options);

            public Vector2 scrollPosition { get; protected set; }
            public bool handleScrollWheel { get; set; }

            protected override void CloseScope();
        }
        public class FadeGroupScope : GUI.Scope
        {
            public FadeGroupScope(float value);

            public bool visible { get; protected set; }

            protected override void CloseScope();
        }
    }
}
