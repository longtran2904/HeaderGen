#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEditor.ShortcutManagement
{
    public interface IShortcutManager
    {
        string activeProfileId { get; set; }

        event Action<ActiveProfileChangedEventArgs> activeProfileChanged;
        event Action<ShortcutBindingChangedEventArgs> shortcutBindingChanged;

        IEnumerable<string> GetAvailableProfileIds();
        bool IsProfileIdValid(string profileId);
        bool IsProfileReadOnly(string profileId);
        void CreateProfile(string profileId);
        void DeleteProfile(string profileId);
        void RenameProfile(string profileId, string newProfileId);
        IEnumerable<string> GetAvailableShortcutIds();
        ShortcutBinding GetShortcutBinding(string shortcutId);
        void RebindShortcut(string shortcutId, ShortcutBinding binding);
        void ClearShortcutOverride(string shortcutId);
        bool IsShortcutOverridden(string shortcutId);
    }
}
