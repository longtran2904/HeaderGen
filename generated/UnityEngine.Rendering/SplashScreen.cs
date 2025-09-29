#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
    [NativeHeader("Runtime/Graphics/DrawSplashScreenAndWatermarks.h")]
    public class SplashScreen
    {
        public SplashScreen();

        public static bool isFinished { get; }

        [FreeFunction("BeginSplashScreen_Binding")]
        public static void Begin();
        public static void Stop(StopBehavior stopBehavior);
        [FreeFunction("DrawSplashScreen_Binding")]
        public static void Draw();

        public enum StopBehavior
        {
            StopImmediate = 0,
            FadeOut = 1
        }
    }
}
