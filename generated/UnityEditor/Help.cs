#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/Panels/HelpPanel.h")]
    [NativeHeader("Editor/Platform/Interface/EditorUtility.h")]
    [NativeHeader("Editor/Src/Utility/DocUtilities.h")]
    public class Help
    {

        public Help();

        public static bool HasHelpForObject(UnityEngine.Object obj);
        public static string GetHelpURLForObject(UnityEngine.Object obj);
        public static void ShowHelpForObject(UnityEngine.Object obj);
        public static void ShowHelpPage(string page);
        public static void BrowseURL(string url);
    }
}
