#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor
{
    [InitializeOnLoad]
    public static class SettingsService
    {
        public static EditorWindow OpenProjectSettings(string settingsPath = null);
        public static EditorWindow OpenUserPreferences(string settingsPath = null);
        public static void NotifySettingsProviderChanged();
        public static void RepaintAllSettingsWindow();
    }
}
