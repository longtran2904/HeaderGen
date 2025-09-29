#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering
{
    public struct LightUnitSliderUIRange
    {
        public GUIContent content;
        public Vector2 value;
        public float presetValue;

        public LightUnitSliderUIRange(Texture2D icon, string tooltip, Vector2 value);
        public LightUnitSliderUIRange(Texture2D icon, string tooltip, Vector2 value, float presetValue);

        public static LightUnitSliderUIRange CautionRange(string tooltip, float value);
    }
}
