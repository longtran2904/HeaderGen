#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.iOS;

namespace UnityEngine
{
    [NativeHeader("Runtime/Input/GetInput.h")]
    [NativeHeader("Runtime/Video/MoviePlayback.h")]
    [NativeHeader("Runtime/Export/Handheld/Handheld.bindings.h")]
    public class Handheld
    {
        public Handheld();

        [Obsolete("Property Handheld.use32BitDisplayBuffer has been deprecated. Modifying it has no effect, use PlayerSettings instead.")]
        public static bool use32BitDisplayBuffer { get; set; }

        public static bool PlayFullScreenMovie(string path, [DefaultValue("Color.black")] Color bgColor, [DefaultValue("FullScreenMovieControlMode.Full")] FullScreenMovieControlMode controlMode, [DefaultValue("FullScreenMovieScalingMode.AspectFit")] FullScreenMovieScalingMode scalingMode);
        [ExcludeFromDocs]
        public static bool PlayFullScreenMovie(string path, Color bgColor, FullScreenMovieControlMode controlMode);
        [ExcludeFromDocs]
        public static bool PlayFullScreenMovie(string path, Color bgColor);
        [ExcludeFromDocs]
        public static bool PlayFullScreenMovie(string path);
        [FreeFunction("Vibrate")]
        public static void Vibrate();
        public static void SetActivityIndicatorStyle(ActivityIndicatorStyle style);
        public static void SetActivityIndicatorStyle(AndroidActivityIndicatorStyle style);
        [FreeFunction("GetActivityIndicatorStyle_Bindings")]
        public static int GetActivityIndicatorStyle();
        [FreeFunction("StartActivityIndicator_Bindings")]
        public static void StartActivityIndicator();
        [FreeFunction("StopActivityIndicator_Bindings")]
        public static void StopActivityIndicator();
        [FreeFunction("ClearShaderCache_Bindings")]
        public static void ClearShaderCache();
    }
}
