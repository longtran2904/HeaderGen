#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Rendering
{
    public class VolumesPreferences : ICoreRenderPipelinePreferencesProvider
    {
        public VolumesPreferences();

        public static VolumeGizmoVisibility volumeGizmosVisibilityOption { get; set; }
        public static bool drawWireFrame { get; }
        public static bool drawSolid { get; }
        public static Color volumeGizmoColor { get; }
        public List<string> keywords { get; }
        public GUIContent header { get; }

        public void PreferenceGUI();

        [Flags]
        public enum VolumeGizmoVisibility
        {
            Wireframe = 1,
            Solid = 2,
            Everything = 3
        }
    }
}
