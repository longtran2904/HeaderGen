#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Internal;

namespace UnityEngine
{
    public sealed class Screen
    {

        public Screen();

        public static int width { get; }
        public static int height { get; }
        public static float dpi { get; }
        public static Resolution currentResolution { get; }
        public static Resolution[] resolutions { get; }
        public static bool fullScreen { get; set; }
        public static FullScreenMode fullScreenMode { get; set; }
        public static Rect safeArea { get; }
        public static Rect[] cutouts { get; }
        public static bool autorotateToPortrait { get; set; }
        public static bool autorotateToPortraitUpsideDown { get; set; }
        public static bool autorotateToLandscapeLeft { get; set; }
        public static bool autorotateToLandscapeRight { get; set; }
        public static ScreenOrientation orientation { get; set; }
        public static int sleepTimeout { get; set; }
        public static float brightness { get; set; }
        public static Vector2Int mainWindowPosition { get; }
        public static DisplayInfo mainWindowDisplayInfo { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property GetResolution has been deprecated. Use resolutions instead (UnityUpgradable) -> resolutions", True)]
        public static Resolution[] GetResolution { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property showCursor has been deprecated. Use Cursor.visible instead (UnityUpgradable) -> UnityEngine.Cursor.visible", True)]
        public static bool showCursor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use Cursor.lockState and Cursor.visible instead.", False)]
        public static bool lockCursor { get; set; }

        public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, [DefaultValue("0")] int preferredRefreshRate);
        public static void SetResolution(int width, int height, FullScreenMode fullscreenMode);
        public static void SetResolution(int width, int height, bool fullscreen, [DefaultValue("0")] int preferredRefreshRate);
        public static void SetResolution(int width, int height, bool fullscreen);
        public static void GetDisplayLayout(List<DisplayInfo> displayLayout);
        public static AsyncOperation MoveMainWindowTo(in DisplayInfo display, Vector2Int position);
    }
}
