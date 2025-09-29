#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.ShortcutManagement
{
    public struct KeyCombination : IEquatable<KeyCombination>
    {
        public KeyCombination(KeyCode keyCode, ShortcutModifiers shortcutModifiers = ShortcutModifiers.None);

        public KeyCode keyCode { get; }
        public ShortcutModifiers modifiers { get; }
        public bool alt { get; }
        public bool action { get; }
        public bool shift { get; }
        public bool control { get; }

        public override string ToString();
        public bool Equals(KeyCombination other);
        public override bool Equals(object obj);
        public override int GetHashCode();
    }
}
