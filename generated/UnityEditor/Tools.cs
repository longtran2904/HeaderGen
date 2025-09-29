#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor
{
    public sealed class Tools : ScriptableObject
    {
        public Tools();

        public static Tool current { get; set; }
        public static ViewTool viewTool { get; set; }
        public static bool viewToolActive { get; }
        public static Vector3 handlePosition { get; }
        public static Rect handleRect { get; }
        public static Quaternion handleRectRotation { get; }
        public static PivotMode pivotMode { get; set; }
        public static bool rectBlueprintMode { get; set; }
        public static Quaternion handleRotation { get; set; }
        public static PivotRotation pivotRotation { get; set; }
        public static bool hidden { get; set; }
        public static int visibleLayers { get; set; }
        public static int lockedLayers { get; set; }

        public static event Action pivotModeChanged;
        public static event Action pivotRotationChanged;
        public static event Action viewToolChanged;
    }
}
