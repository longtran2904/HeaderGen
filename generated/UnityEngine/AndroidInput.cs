#region UnityEngine.InputLegacyModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.InputLegacyModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Input/GetInput.h")]
    public class AndroidInput
    {
        public static int touchCountSecondary { get; }
        public static bool secondaryTouchEnabled { get; }
        public static int secondaryTouchWidth { get; }
        public static int secondaryTouchHeight { get; }

        public static Touch GetSecondaryTouch(int index);
    }
}
