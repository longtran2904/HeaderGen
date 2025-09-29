#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.ShortcutManagement
{
    public struct ShortcutBindingChangedEventArgs
    {

        public ShortcutBindingChangedEventArgs(string shortcutId, ShortcutBinding oldBinding, ShortcutBinding newBinding);

        public string shortcutId { get; }
        public ShortcutBinding oldBinding { get; }
        public ShortcutBinding newBinding { get; }
    }
}
