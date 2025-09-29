#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.ShortcutManagement
{
    public struct ActiveProfileChangedEventArgs
    {
        public ActiveProfileChangedEventArgs(string previousActiveProfileId, string currentActiveProfileId);

        public string previousActiveProfileId { get; }
        public string currentActiveProfileId { get; }
    }
}
