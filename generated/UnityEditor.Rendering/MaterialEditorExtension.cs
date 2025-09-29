#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.Rendering
{
    public static class MaterialEditorExtension
    {
        public static void IntShaderProperty(this MaterialEditor editor, MaterialProperty prop, GUIContent label, Func<int, int> transform = null);
        public static void IntSliderShaderProperty(this MaterialEditor editor, MaterialProperty prop, GUIContent label);
        public static void IntSliderShaderProperty(this MaterialEditor editor, MaterialProperty prop, int min, int max, GUIContent label);
        public static void MinFloatShaderProperty(this MaterialEditor editor, MaterialProperty prop, GUIContent label, float min);
        public static int PopupShaderProperty(this MaterialEditor editor, MaterialProperty prop, GUIContent label, string[] displayedOptions);
        public static int IntPopupShaderProperty(this MaterialEditor editor, MaterialProperty prop, string label, string[] displayedOptions, int[] optionValues);
        public static void MinMaxShaderProperty(this MaterialEditor editor, MaterialProperty min, MaterialProperty max, float minLimit, float maxLimit, GUIContent label);
        public static void MinMaxShaderProperty(this MaterialEditor editor, MaterialProperty remapProp, float minLimit, float maxLimit, GUIContent label);
    }
}
