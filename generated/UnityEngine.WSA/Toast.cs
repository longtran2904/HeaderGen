#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.WSA
{
    [NativeConditional("PLATFORM_WINRT")]
    [NativeHeader("Runtime/Export/WSA/WSATiles.bindings.h")]
    [StaticAccessor("WSATilesBindings::Toast", StaticAccessorType.DoubleColon)]
    public sealed class Toast
    {

        public string arguments { get; set; }
        public bool activated { get; }
        public bool dismissed { get; }
        public bool dismissedByUser { get; }

        public static string GetTemplate(ToastTemplate templ);
        public static Toast Create(string xml);
        public static Toast Create(string image, string text);
        public void Show();
        public void Hide();
    }
}
