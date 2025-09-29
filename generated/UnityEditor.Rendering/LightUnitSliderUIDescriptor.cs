#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering
{
    public struct LightUnitSliderUIDescriptor
    {

        public readonly float[] sliderDistribution;
        public readonly LightUnitSliderUIRange[] valueRanges;
        public readonly Vector2 sliderRange;
        public readonly string belowRangeTooltip;
        public readonly string aboveRangeTooltip;
        public readonly string unitName;
        public readonly bool hasMarkers;
        public readonly bool clampValue;

        public LightUnitSliderUIDescriptor(LightUnitSliderUIRange[] valueRanges, float[] sliderDistribution, string cautionTooltip, string unitName, bool hasMarkers = True, bool clampValue = False);
        public LightUnitSliderUIDescriptor(LightUnitSliderUIRange[] valueRanges, float[] sliderDistribution, string belowRangeTooltip, string aboveRangeTooltip, string unitName, bool hasMarkers = True, bool clampValue = False);
    }
}
