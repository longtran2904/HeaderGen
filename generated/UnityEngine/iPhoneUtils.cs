#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class iPhoneUtils
    {

        public iPhoneUtils();

        [Obsolete("isApplicationGenuine property is deprecated. Please use Application.genuine instead (UnityUpgradable) -> Application.genuine")]
        public static bool isApplicationGenuine { get; }
        [Obsolete("isApplicationGenuineAvailable property is deprecated. Please use Application.genuineCheckAvailable instead (UnityUpgradable) -> Application.genuineCheckAvailable")]
        public static bool isApplicationGenuineAvailable { get; }

        [Obsolete("PlayMovie method is deprecated. Please use Handheld.PlayFullScreenMovie instead (UnityUpgradable) -> [mscorlib] System.Boolean Handheld.PlayFullScreenMovie(*)")]
        public static void PlayMovie(string path, Color bgColor, iPhoneMovieControlMode controlMode, iPhoneMovieScalingMode scalingMode);
        [Obsolete("PlayMovie method is deprecated. Please use Handheld.PlayFullScreenMovie instead (UnityUpgradable) -> [mscorlib] System.Boolean Handheld.PlayFullScreenMovie(*)")]
        public static void PlayMovie(string path, Color bgColor, iPhoneMovieControlMode controlMode);
        [Obsolete("PlayMovie method is deprecated. Please use Handheld.PlayFullScreenMovie instead (UnityUpgradable) -> [mscorlib] System.Boolean Handheld.PlayFullScreenMovie(*)")]
        public static void PlayMovie(string path, Color bgColor);
        [Obsolete("PlayMovieURL method is deprecated. Please use Handheld.PlayFullScreenMovie instead (UnityUpgradable) -> [mscorlib] System.Boolean Handheld.PlayFullScreenMovie(*)")]
        public static void PlayMovieURL(string url, Color bgColor, iPhoneMovieControlMode controlMode, iPhoneMovieScalingMode scalingMode);
        [Obsolete("PlayMovieURL method is deprecated. Please use Handheld.PlayFullScreenMovie instead (UnityUpgradable) -> [mscorlib] System.Boolean Handheld.PlayFullScreenMovie(*)")]
        public static void PlayMovieURL(string url, Color bgColor, iPhoneMovieControlMode controlMode);
        [Obsolete("PlayMovieURL method is deprecated. Please use Handheld.PlayFullScreenMovie instead (UnityUpgradable) -> [mscorlib] System.Boolean Handheld.PlayFullScreenMovie(*)")]
        public static void PlayMovieURL(string url, Color bgColor);
        [Obsolete("Vibrate method is deprecated. Please use Handheld.Vibrate instead (UnityUpgradable) -> Handheld.Vibrate()")]
        public static void Vibrate();
    }
}
