#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering
{
    public class LightUnitSlider
    {

        protected SerializedObject m_SerializedObject;
        protected readonly LightUnitSliderUIDescriptor m_Descriptor;

        public LightUnitSlider(LightUnitSliderUIDescriptor descriptor);

        public void SetSerializedObject(SerializedObject serialized);
        public virtual void Draw(Rect rect, SerializedProperty value, ref float floatValue);
        protected virtual void SetValueToPreset(SerializedProperty value, LightUnitSliderUIRange preset);
        protected virtual GUIContent GetLightUnitTooltip(string baseTooltip, float value, string unit);
        protected virtual void DoSlider(Rect rect, ref float value, Vector2 sliderRange, Vector2 _);
        protected virtual void DoSlider(Rect rect, ref float value, Vector2 sliderRange);
        protected virtual float GetPositionOnSlider(float value, Vector2 valueRange);
        protected virtual float GetPositionOnSlider(float value);
        protected static class SliderStyles
        {

            public static GUIStyle k_IconButton;
            public static GUIStyle k_TemperatureBorder;
            public static GUIStyle k_TemperatureThumb;
        }
    }
}
