#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/MenuController.h")]
    public sealed class Menu
    {
        public Menu();

        [NativeMethod("MenuController::SetChecked", True)]
        public static void SetChecked(string menuPath, bool isChecked);
        [NativeMethod("MenuController::GetChecked", True)]
        public static bool GetChecked(string menuPath);
        [NativeMethod("MenuController::GetEnabled", True)]
        public static bool GetEnabled(string menuPath);
    }
}
