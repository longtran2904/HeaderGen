#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering
{
    public static class CameraUI
    {
        public static void Drawer_Projection(ISerializedCamera p, Editor owner);

        public enum ProjectionType
        {
            Perspective = 0,
            Orthographic = 1
        }
        public enum ProjectionMatrixMode
        {
            Explicit = 0,
            Implicit = 1,
            PhysicalPropertiesBased = 2
        }
        public static class Environment
        {
            public static void Drawer_Environment_VolumeLayerMask(ISerializedCamera p, Editor owner);

            public static class Styles
            {
                public static readonly GUIContent header;
                public static readonly GUIContent volumeLayerMask;
            }
        }
        public static class Output
        {
            public static void Drawer_Output_AllowDynamicResolution(ISerializedCamera p, Editor owner);
            public static void Drawer_Output_NormalizedViewPort(ISerializedCamera p, Editor owner);
            public static void Drawer_Output_Depth(ISerializedCamera p, Editor owner);
            public static void Drawer_Output_RenderTarget(ISerializedCamera p, Editor owner);

            public static class Styles
            {
                public static readonly GUIContent header;
                public static readonly GUIContent targetDisplay;
                public static readonly GUIContent viewport;
                public static readonly GUIContent allowDynamicResolution;
                public static readonly GUIContent depth;
            }
        }
        public static class PhysicalCamera
        {
            public static void Drawer_PhysicalCamera_CameraBody_Sensor(ISerializedCamera p, Editor owner);
            public static void Drawer_PhysicalCamera_CameraBody_GateFit(ISerializedCamera p, Editor owner);
            public static void Drawer_PhysicalCamera_Lens_FocalLength(ISerializedCamera p, Editor owner);
            public static void Drawer_PhysicalCamera_Lens_Shift(ISerializedCamera p, Editor owner);

            public static class Styles
            {
                public static readonly GUIContent cameraBody;
                public static readonly GUIContent sensorType;
                public static readonly string[] apertureFormatNames;
                public static readonly Vector2[] apertureFormatValues;
                public static readonly int customPresetIndex;
                public static readonly GUIContent sensorSize;
                public static readonly GUIContent gateFit;
                public static readonly GUIContent lens;
                public static readonly GUIContent focalLength;
                public static readonly GUIContent shift;
            }
        }
        public static class Rendering
        {
            public static void Drawer_Rendering_StopNaNs(ISerializedCamera p, Editor owner);
            public static void Drawer_Rendering_Dithering(ISerializedCamera p, Editor owner);
            public static void Drawer_Rendering_CullingMask(ISerializedCamera p, Editor owner);
            public static void Drawer_Rendering_OcclusionCulling(ISerializedCamera p, Editor owner);

            public static class Styles
            {
                public static readonly GUIContent header;
                public static readonly GUIContent antialiasing;
                public static readonly GUIContent dithering;
                public static readonly GUIContent stopNaNs;
                public static readonly GUIContent cullingMask;
                public static readonly GUIContent occlusionCulling;
                public static readonly GUIContent renderingPath;
                public static readonly GUIContent exposureTarget;
            }
        }
        public static class Styles
        {
            public static GUIContent clippingPlaneMultiFieldTitle;
            public static readonly GUIContent projectionContent;
            public static readonly GUIContent sizeContent;
            public static readonly GUIContent fieldOfViewContent;
            public static readonly GUIContent FOVAxisModeContent;
            public static readonly GUIContent physicalCameraContent;
            public static readonly GUIContent nearPlaneContent;
            public static readonly GUIContent farPlaneContent;
            public static readonly string unsupportedPresetPropertiesMessage;

            public static GUIContent projectionSettingsHeaderContent { get; }
        }
    }
}
