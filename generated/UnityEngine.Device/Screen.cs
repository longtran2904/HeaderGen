#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Internal;

namespace UnityEngine.Device
{
    public static class Screen
    {

        public static bool autorotateToLandscapeLeft { get; set; }
        public static bool autorotateToLandscapeRight { get; set; }
        public static bool autorotateToPortrait { get; set; }
        public static bool autorotateToPortraitUpsideDown { get; set; }
        public static Resolution currentResolution { get; }
        public static Rect[] cutouts { get; }
        public static float dpi { get; }
        public static bool fullScreen { get; set; }
        public static FullScreenMode fullScreenMode { get; set; }
        public static int height { get; }
        public static int width { get; }
        public static ScreenOrientation orientation { get; set; }
        public static Resolution[] resolutions { get; }
        public static Rect safeArea { get; }
        public static int sleepTimeout { get; set; }
        public static float brightness { get; set; }
        public static Vector2Int mainWindowPosition { get; }
        public static DisplayInfo mainWindowDisplayInfo { get; }

        public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, [DefaultValue("0")] int preferredRefreshRate);
        public static void SetResolution(int width, int height, FullScreenMode fullscreenMode);
        public static void SetResolution(int width, int height, bool fullscreen, [DefaultValue("0")] int preferredRefreshRate);
        public static void SetResolution(int width, int height, bool fullscreen);
        public static void GetDisplayLayout(List<DisplayInfo> displayLayout);
        public static AsyncOperation MoveMainWindowTo(in DisplayInfo display, Vector2Int position);
    }
}
