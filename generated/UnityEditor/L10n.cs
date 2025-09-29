#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Internal;

namespace UnityEditor
{
    public static class L10n
    {
        public static string Tr(string str);
        public static string[] Tr(string[] str_list);
        public static string Tr(string str, string groupName);
        [ExcludeFromDocs]
        public static string TrPath(string path);
        [ExcludeFromDocs]
        public static GUIContent TextContent(string text, string tooltip = null, Texture icon = null);
        [ExcludeFromDocs]
        public static GUIContent TextContent(string text, string tooltip, string iconName);
        [ExcludeFromDocs]
        public static GUIContent TextContent(string text, Texture icon);
        [ExcludeFromDocs]
        public static GUIContent TextContentWithIcon(string text, Texture icon);
        [ExcludeFromDocs]
        public static GUIContent TextContentWithIcon(string text, string iconName);
        [ExcludeFromDocs]
        public static GUIContent TextContentWithIcon(string text, string tooltip, string iconName);
        [ExcludeFromDocs]
        public static GUIContent TextContentWithIcon(string text, string tooltip, Texture icon);
        [ExcludeFromDocs]
        public static GUIContent TextContentWithIcon(string text, string tooltip, MessageType messageType);
        [ExcludeFromDocs]
        public static GUIContent TextContentWithIcon(string text, MessageType messageType);
        [ExcludeFromDocs]
        public static GUIContent IconContent(string iconName, string tooltip = null);
        [ExcludeFromDocs]
        public static GUIContent IconContent(Texture icon, string tooltip = null);
        [ExcludeFromDocs]
        public static GUIContent TempContent(string t);
        [ExcludeFromDocs]
        public static GUIContent[] TempContent(string[] texts);
        [ExcludeFromDocs]
        public static GUIContent[] TempContent(string[] texts, string[] tooltips);
    }
}
