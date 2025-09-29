#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine;

namespace UnityEditor.ShortcutManagement
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = True)]
    public class ShortcutAttribute : ShortcutBaseAttribute
    {
        public ShortcutAttribute(string id, [DefaultValue("null")] Type context = null);
        public ShortcutAttribute(string id, Type context, KeyCode defaultKeyCode, [DefaultValue("None")] ShortcutModifiers defaultShortcutModifiers = ShortcutModifiers.None);
        public ShortcutAttribute(string id, KeyCode defaultKeyCode, [DefaultValue("None")] ShortcutModifiers defaultShortcutModifiers = ShortcutModifiers.None);

        public string displayName { get; set; }
    }
}
