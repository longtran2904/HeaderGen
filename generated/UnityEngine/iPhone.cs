#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("iPhone class is deprecated. Please use iOS.Device instead (UnityUpgradable) -> UnityEngine.iOS.Device", True)]
    public sealed class iPhone
    {

        public iPhone();

        public static iPhoneGeneration generation { get; }
        public static string vendorIdentifier { get; }
        public static string advertisingIdentifier { get; }
        public static bool advertisingTrackingEnabled { get; }

        public static void SetNoBackupFlag(string path);
        public static void ResetNoBackupFlag(string path);
    }
}
