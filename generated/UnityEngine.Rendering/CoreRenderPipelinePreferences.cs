#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public static class CoreRenderPipelinePreferences
    {

        [Obsolete("Use VolumePreferences", False)]
        public static Color volumeGizmoColor { get; }
        public static Color previewBackgroundColor { get; }

        public static Func<Color> RegisterPreferenceColor(string name, Color defaultColor);
    }
}
