#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine.iOS
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("iOS.ADInterstitialAd class is obsolete, Apple iAD service discontinued", True)]
    public sealed class ADInterstitialAd
    {
        public ADInterstitialAd(bool autoReload);
        public ADInterstitialAd();

        public static bool isAvailable { get; }
        public bool loaded { get; }

        public static event InterstitialWasLoadedDelegate onInterstitialWasLoaded;
        public static event InterstitialWasViewedDelegate onInterstitialWasViewed;

        public void Show();
        public void ReloadAd();

        public delegate void InterstitialWasLoadedDelegate();
        public delegate void InterstitialWasViewedDelegate();
    }
}
