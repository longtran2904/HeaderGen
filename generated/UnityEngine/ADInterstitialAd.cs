#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("ADInterstitialAd class is obsolete, Apple iAD service discontinued", True)]
    public sealed class ADInterstitialAd
    {

        public ADInterstitialAd(bool autoReload);
        public ADInterstitialAd();

        ~ADInterstitialAd();

        public static bool isAvailable { get; }
        public bool loaded { get; }

        public static event InterstitialWasLoadedDelegate onInterstitialWasLoaded;

        public void Show();
        public void ReloadAd();
        public delegate void InterstitialWasLoadedDelegate();
    }
}
