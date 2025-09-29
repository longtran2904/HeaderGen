#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Export/Math/ColorUtility.bindings.h")]
    public class ColorUtility
    {
        public ColorUtility();

        public static bool TryParseHtmlString(string htmlString, out Color color);
        public static string ToHtmlStringRGB(Color color);
        public static string ToHtmlStringRGBA(Color color);
    }
}
