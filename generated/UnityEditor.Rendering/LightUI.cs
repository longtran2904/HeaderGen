#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering
{
    public class LightUI
    {

        public LightUI();

        public static void DrawColor(ISerializedLight serialized, Editor owner);
        public static class Styles
        {

            public static readonly GUIContent generalHeader;
            public static readonly GUIContent shapeHeader;
            public static readonly GUIContent renderingHeader;
            public static readonly GUIContent emissionHeader;
            public static readonly GUIContent shadowHeader;
            public static readonly GUIContent lightLayer;
            public static readonly GUIContent color;
            public static readonly GUIContent lightAppearance;
            public static readonly GUIContent[] lightAppearanceOptions;
            public static readonly GUIContent[] lightAppearanceUnits;
            public static readonly GUIContent colorFilter;
            public static readonly GUIContent colorTemperature;
            public static readonly string unsupportedPresetPropertiesMessage;
        }
    }
}
