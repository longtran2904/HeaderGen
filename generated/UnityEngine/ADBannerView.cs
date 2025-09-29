#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("ADBannerView class is obsolete, Apple iAD service discontinued", True)]
    public sealed class ADBannerView
    {
        public ADBannerView(Type type, Layout layout);

        public bool loaded { get; }
        public bool visible { get; set; }
        public Layout layout { get; set; }
        public Vector2 position { get; set; }
        public Vector2 size { get; }

        public static event BannerWasClickedDelegate onBannerWasClicked;
        public static event BannerWasLoadedDelegate onBannerWasLoaded;

        public static bool IsAvailable(Type type);

        public enum Layout
        {
            Top = 0,
            Bottom = 1,
            TopLeft = 0,
            TopRight = 4,
            TopCenter = 8,
            BottomLeft = 1,
            BottomRight = 5,
            BottomCenter = 9,
            CenterLeft = 2,
            CenterRight = 6,
            Center = 10,
            Manual = -1
        }
        public enum Type
        {
            Banner = 0,
            MediumRect = 1
        }
        public delegate void BannerWasClickedDelegate();
        public delegate void BannerWasLoadedDelegate();
    }
}
