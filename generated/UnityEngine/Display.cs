#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/DisplayManager.h")]
    [UsedByNativeCode]
    public class Display
    {

        public static Display[] displays;

        public int renderingWidth { get; }
        public int renderingHeight { get; }
        public int systemWidth { get; }
        public int systemHeight { get; }
        public RenderBuffer colorBuffer { get; }
        public RenderBuffer depthBuffer { get; }
        public bool active { get; }
        public bool requiresBlitToBackbuffer { get; }
        public bool requiresSrgbBlitToBackbuffer { get; }
        public static Display main { get; }
        public static int activeEditorGameViewTarget { get; }

        public static event DisplaysUpdatedDelegate onDisplaysUpdated;

        public void Activate();
        public void Activate(int width, int height, int refreshRate);
        public void SetParams(int width, int height, int x, int y);
        public void SetRenderingResolution(int w, int h);
        [Obsolete("MultiDisplayLicense has been deprecated.", False)]
        public static bool MultiDisplayLicense();
        public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates);
        public delegate void DisplaysUpdatedDelegate();
    }
}
